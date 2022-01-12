using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    internal class ConnectionView //Datas of the DataGridView will be created here
    {
        public string StartTime { get; set; }
        public string StartStation { get; set; }
        public string Platform { get; set; }
        public string EndTime { get; set; }
        public string EndStation { get; set; }

        public ConnectionView(string startTime, string startStation, string platform, string endTime, string endStation)
        {
            StartTime = startTime;
            StartStation = startStation;
            Platform = platform;
            EndTime = endTime;
            EndStation = endStation;
        }
    }
}
