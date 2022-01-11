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
        private string TimeHourMinuteFormat = "HH:mm";

        public TransportAppMainForm()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(StartStationTxt.Text))
            {
                MessageBox.Show(ErrorNoStartStation);
                return;
            }
            if (String.IsNullOrEmpty(EndStationTxt.Text))
            {
                MessageBox.Show(ErrorNoEndStation);
                return;
            }
            ConnectionViews.Clear();
            List<Connection> Connections = new();
            Connections.AddRange(transport.GetConnections(StartStationTxt.Text, EndStationTxt.Text).ConnectionList);
            foreach (Connection c in Connections)
            {
                ConnectionView NewView = new();
                NewView.StartTime = c.From.Departure.Value.ToString(TimeHourMinuteFormat);
                NewView.EndTime = c.To.Arrival.Value.ToString(TimeHourMinuteFormat);
                NewView.StartStation = c.From.Station.Name;
                NewView.EndStation = c.To.Station.Name;
                NewView.Platform = c.From.Platform;
                ConnectionViews.Add(NewView);
            }

        }

        private void TransportAppMainForm_Load(object sender, EventArgs e)
        {
            ConnectionsDgv.DataSource = ConnectionViews;
        }
    }
}