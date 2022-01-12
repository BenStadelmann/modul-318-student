using SwissTransport.Core;
using SwissTransport.Models;
using System.ComponentModel;
using System.Globalization;

namespace TransportApp
{
    public partial class TransportAppMainForm : Form
    {
        ITransport transport = new Transport();
        private BindingList<ConnectionView> ConnectionViews = new();

        private string ErrorNoStartStation = "Geben sie eine Startstation an!!";
        private string ErrorNoEndStation = "Geben sie eine Endstation an!!";
        private const string TimeHourMinuteFormat = "HH:mm";

        public TransportAppMainForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ConnectionViews.Clear();
            if (String.IsNullOrEmpty(StartStationCbx.Text))
            {
                MessageBox.Show(ErrorNoStartStation);
                return;
            }
            if (String.IsNullOrEmpty(EndStationCbx.Text))
            {
                List<StationBoard> stationBoards = new();
                StationBoardRoot Root = new();
                Root = transport.GetStationBoard(StartStationCbx.Text, "id");
                stationBoards = Root.Entries;
                string StationName = Root.Station.Name;
                foreach (StationBoard stationBoard in stationBoards)
                    ConnectionViews.Add(new ConnectionView(stationBoard.Stop.Departure.ToString(TimeHourMinuteFormat), StationName, "", "", stationBoard.To));
                return;
            }
            List<Connection> Connections = new();
            Connections.AddRange(transport.GetConnections(StartStationCbx.Text, EndStationCbx.Text).ConnectionList);
            foreach (Connection c in Connections)
                if (c.From.Departure.HasValue && c.To.Arrival.HasValue)
                    ConnectionViews.Add(new ConnectionView(c.From.Departure.Value.ToString(TimeHourMinuteFormat), c.From.Station.Name, c.From.Platform, c.To.Arrival.Value.ToString(TimeHourMinuteFormat), c.To.Station.Name));
        }

        private void TransportAppMainForm_Load(object sender, EventArgs e)
        {
            ConnectionsDgv.DataSource = ConnectionViews;
        }

        private void GetOffers(object sender, EventArgs e)
        {
            ComboBox SenderCbx = (ComboBox)sender;
            SenderCbx.Items.Clear();
            if (String.IsNullOrEmpty(SenderCbx.Text))
                return;
            List<Station> stations = new();
            stations = transport.GetStations(SenderCbx.Text).StationList;
            foreach (Station station in stations)
                if (station.Name != null)
                    SenderCbx.Items.Add(station.Name);
        }
    }
}