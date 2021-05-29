using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWell
{
    public class Rendezvous
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> DatePrise { get; set; }
        public Nullable<System.TimeSpan> Temp { get; set; }
        public string patient { get; set; }
    }
}
