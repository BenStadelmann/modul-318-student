using SwissTransport.Core;
using SwissTransport.Models;
using System.ComponentModel;
using System.Globalization;

namespace TransportApp
{
    public partial class TransportAppMainForm : Form
    {
        private ITransport transport = new Transport();
        private BindingList<ConnectionView> connectionViews = new();

        private const string errorNoStartStation = "Geben sie eine Startstation an!!";
        private const string errorNoConnections = "Es gibt keine Verbindungen!!";
        private const string timeHourMinuteFormat = "HH:mm";
        private const string id = "id";

        public TransportAppMainForm()
        {
            InitializeComponent();
        }

        private void TransportAppMainForm_Load(object sender, EventArgs e)
        {
            ConnectionsDgv.DataSource = connectionViews;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            connectionViews.Clear(); //clear BindingList
            if (String.IsNullOrEmpty(StartStationCbx.Text))
            {
                MessageBox.Show(errorNoStartStation);
                return;
            }
            if (String.IsNullOrEmpty(EndStationCbx.Text))
            {
                List<StationBoard> stationBoards = new();
                StationBoardRoot root = new();

                root = transport.GetStationBoard(StartStationCbx.Text, id);
                stationBoards = root.Entries;
                string stationName = root.Station.Name;

                if (stationBoards.Count <= 0) //No Connections Filter
                    MessageBox.Show(errorNoConnections);

                foreach (StationBoard stationBoard in stationBoards)
                    if (stationBoard.Stop.Departure >= TimeDtp.Value) //Time-Filtering
                        connectionViews.Add(new ConnectionView(stationBoard.Stop.Departure.ToString(timeHourMinuteFormat), stationName, String.Empty, String.Empty, stationBoard.To)); //Create new Record of what i wanna see and add to the BindingList

                return;
            }
            List<Connection> connections = new();

            connections.AddRange(transport.GetConnections(StartStationCbx.Text, EndStationCbx.Text, TimeDtp.Value, ArrivalTimeBool.Checked).ConnectionList); //Get Connections and add those to  a List

            if (connections.Count <= 0) //No Connections Filter
                MessageBox.Show(errorNoConnections);

            foreach (Connection c in connections)
                if (c.From.Departure.HasValue && c.To.Arrival.HasValue) //NotNullFilter of Start- and End-Stations Time
                    connectionViews.Add(new ConnectionView(c.From.Departure.Value.ToString(timeHourMinuteFormat), c.From.Station.Name, c.From.Platform, c.To.Arrival.Value.ToString(timeHourMinuteFormat), c.To.Station.Name)); //Create new Record of what i wanna see and add to the BindingList
        }

        private void GetOffers(object sender, EventArgs e)
        {
            ComboBox senderCbx = (ComboBox)sender; //Formate sender to Combobox cause event off multible Comboboxes

            senderCbx.Items.Clear();

            if (String.IsNullOrEmpty(senderCbx.Text))
                return;

            List<Station> stations = new();

            stations = transport.GetStations(senderCbx.Text).StationList;

            foreach (Station station in stations)
                if (station.Name != null)
                    senderCbx.Items.Add(station.Name);
        }

        private void SetRealStationNameInComboBox(object sender, EventArgs e) //Sets a misstipped station to the most likely next stations name
        {
            ComboBox senderCbx = (ComboBox)sender; //Formate sender to Combobox cause event off multible Comboboxes

            if (!string.IsNullOrEmpty(senderCbx.Text))
            {
                string realStationName = transport.GetStations(senderCbx.Text).StationList[0].Name; //StationList[0] ist the most likely station that was meant

                if (realStationName != senderCbx.Text)
                    senderCbx.Text = realStationName;
            }
        }

        private void ArrivalTimeBool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ArrivalTimeBool.Checked)
                    ArrivalTimeBool.Checked = false;
                else
                    ArrivalTimeBool.Checked = true;
            }
            
        }
    }
}