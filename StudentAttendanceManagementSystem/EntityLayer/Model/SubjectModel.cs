using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class SubjectModel
    {
        private int _subjectID;
        private string _subjectName;
        public int SujectID { get => _subjectID; set => _subjectID = value; }
        public string SubjectName { get => _subjectName; set => _subjectName = value; }

    }
}
