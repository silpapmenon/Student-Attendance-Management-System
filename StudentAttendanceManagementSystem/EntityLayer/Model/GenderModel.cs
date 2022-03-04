using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class GenderModel
    {
        private int _genderID;
        private string _genderName;
        public int GenderID { get => _genderID; set => _genderID = value; }
        public string GenderName { get => _genderName; set => _genderName = value; }
    }
}
