using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class DivisionModel
    {
        private int _divisionID;
        private string _divisionName;
        private int _standardID;
        private int _seat;
        public int DivisionID { get => _divisionID; set => _divisionID = value; }
        public string DivisionName { get => _divisionName; set => _divisionName = value; }
        public int StandardID { get => _standardID; set => _standardID = value; }
        public int Seat { get => _seat; set => _seat = value; }
    }
}
