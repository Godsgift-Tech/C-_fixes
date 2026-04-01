using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vehicles

    {
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public List<string> CarOptions { get; set; } = new List<string>();
        public List<string> DriverOptions { get; set; } = new List<string>();
        public int CorrectCarIndex { get; set; }
        public int CorrectDriverIndex { get; set; }

    }
}
