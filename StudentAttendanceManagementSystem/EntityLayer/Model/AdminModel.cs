using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class AdminModel
    {
        private string _username;
        private string _password;
        private int _userID;
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int UserID { get => _userID; set => _userID = value; }
    }
}
