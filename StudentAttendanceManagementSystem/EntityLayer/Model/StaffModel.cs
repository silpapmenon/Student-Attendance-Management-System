using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class StaffModel
    {
        private int _staffID;
        private string _staffName;
        private string _staffEmail;
        private string _staffMobile;
        private string _staffImage;
        private string _qualification;
        private string _staffAddress;
        private string _staffCity;
        private string _staffPincode;
        private string _staffUsername;
        private string _staffPassword;
        private string _staffGender;
        private int _roleID;

        public int StaffID { get => _staffID; set => _staffID = value; }
        public string StaffName { get => _staffName; set => _staffName = value; }
        public string StaffEmail { get => _staffEmail; set => _staffEmail = value; }
        public string StaffMobile { get => _staffMobile; set => _staffMobile = value; }
        public string StaffImage { get => _staffImage; set => _staffImage = value; }
        public string Qualification { get => _qualification; set => _qualification = value; }
        public string StaffAddress { get => _staffAddress; set => _staffAddress = value; }
        public string StaffCity { get => _staffCity; set => _staffCity = value; }
        public string StaffPincode { get => _staffPincode; set => _staffPincode = value; }
        public string StaffUserName { get => _staffUsername; set => _staffUsername = value; }
        public string StaffPassword { get => _staffPassword; set => _staffPassword = value; }
        public string StaffGender { get => _staffGender; set => _staffGender = value; }
        public int RoleID { get => _roleID; set => _roleID = value; }
    }
}
