using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    internal class ConnectionView
    {
        public string StartTime { get; set; }
        public string StartStation { get; set; }
        public string Platform { get; set; }
        public string EndTime { get; set; }
        public string EndStation { get; set; }
    }
}
