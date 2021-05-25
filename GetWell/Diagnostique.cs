using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWell
{
    public class Diagnostique
    {
        public int Id_diag { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Date_diag { get; set; }
        public Nullable<int> Id_patient { get; set; }
        public Nullable<int> Id_doc { get; set; }
    }
}
