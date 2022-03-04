using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class StandardModel
    {
        private int _standardID;
        private string _standardName;
        public int StandardID { get => _standardID; set => _standardID = value; }
        public string StandardName { get => _standardName; set => _standardName = value; }
    }
}
