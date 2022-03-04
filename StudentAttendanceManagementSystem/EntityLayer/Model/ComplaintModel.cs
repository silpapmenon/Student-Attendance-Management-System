using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class ComplaintModel
    {
        private int _complaintID;
        private int _studentID;
        private string _subject;
        private string _message;
        private DateTime _date;

        public int ComplaintID { get => _complaintID; set => _complaintID = value; }
        public int StudentID { get => _studentID; set => _studentID = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
