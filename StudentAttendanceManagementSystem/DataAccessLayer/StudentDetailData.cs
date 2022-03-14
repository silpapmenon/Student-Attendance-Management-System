using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataAccessLayer
{
    internal class StudentDetailData
    {
        public List<StudentModel> GetStudentList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Students


                         select getdata;

            List<StudentModel> studentModels = new List<StudentModel>();
            foreach (var item in result)
            {
                StudentModel studentModel = new StudentModel();
                //studentModel.genderClass = new GenderClass();
               // studentModel.standardClass = new StandardClass();
               // studentModel.StandardName = item.StandardName;
                studentModel.StudentID = item.StudentID;
                studentModel.RollNo = item.RollNo;
                studentModel.StudentName = item.StudentName;
                studentModel.Studentusername = item.StudentUsername;
                studentModel.Studentpassword = item.StudentPassword;
                //studentModel.DivisionName = item.DivisionName;
                studentModel.StudentEmail = item.StudentEmail;
                studentModel.StudentMobile = item.StudentMobile;
                studentModel.DOB = item.DOB;
                //studentModel.Image = item.Image;
                studentModel.StudentAddress = item.StudentAddress;
                studentModel.StudentCity = item.StudentCity;
                studentModel.Studentpincode = item.StudentPincode;
                studentModel.GenderName = item.Gender;
                //studentModel.standardClass.StandardName = item.Stan
                studentModels.Add(studentModel);
            }
            return studentModels;

        }
        public void UpdateStudentData(StudentModel studentModel)
        {


            SqlConnection connection = null;
            using (connection = new SqlConnection("data source =.; database = StudentManagementSystem; integrated security = SSPI"))
            {
                try
                {
                    connection.Open();
                    StudentModel student = new StudentModel();
                    int roll = studentModel.RollNo;
                    //int standardid = studentModel.;
                    int studentid = studentModel.StudentID;
                    string studname = studentModel.StudentName;
                    DateTime dob = studentModel.DOB;
                    string email = studentModel.StudentEmail;
                    int pincode = studentModel.Studentpincode;
                    string username = studentModel.Studentusername;
                    string address = studentModel.StudentAddress;
                    string mobile = studentModel.StudentMobile;
                    //string image = "null";
                    string city = studentModel.StudentCity;
                    string gendername = studentModel.GenderName;
                    //int gender = studentModel.Gender;
                    string password = studentModel.Studentpassword;
                   // string division = studentModel.DivisionName;
                   // string standardname = studentModel.StandardName;

                    SqlCommand command = new SqlCommand("UpdateStudent", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@rollNo", roll);
                    command.Parameters.AddWithValue("@studName", studname);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pincode", pincode);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@mobile", mobile);
                    //command.Parameters.AddWithValue("@image", image);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@gendername", gendername);
                    command.Parameters.AddWithValue("@password", password);
                   // command.Parameters.AddWithValue("@division", division);
                   // command.Parameters.AddWithValue("@standardname", standardname);
                    command.Parameters.AddWithValue("@studentid", studentid);

                    int rowsadded = command.ExecuteNonQuery();
                    MessageBox.Show("Updated Succesfully");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }
}
