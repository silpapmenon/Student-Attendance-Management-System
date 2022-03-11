using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class StudentModel
    {

        public int StudentID { get; set; }
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StandardName { get; set; }
        public string DivisionName { get; set; }
        public string StudentCity { get; set; }
        public string Image { get; set; }
        public int Studentpincode { get; set; }
        public string Studentusername { get; set; }
        public string Studentpassword { get; set; }
        public int StandardID { get; set; }
        public int RoleID { get; set; }
        public int Gender { get; set; }
        public DateTime DOB { get; set; }
        public string StudentEmail { get; set; }
        public string StudentMobile { get; set; }
        public string GenderName { get; set; }
        public GenderClass genderClass { get; set; }
        public StandardClass standardClass { get; set; }


    }
    public class GenderClass
    {
        public int GenderID { get; set; }
        public string GenderName { get; set; }
    }
    public class StandardClass
    {
        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
