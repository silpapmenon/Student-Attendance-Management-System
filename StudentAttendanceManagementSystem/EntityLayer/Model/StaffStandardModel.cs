using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Model
{
    public class StaffStandardModel
    {
        private int _staffstandardId;
        private int _standardId;
        private int _subjectId;
        private int _staffId;

        public int StaffstandardID { get => _staffstandardId; set => _staffstandardId = value; }
        public int StandardID { get => _standardId; set => _standardId = value; }
        public int SubjectID { get => _subjectId; set => _subjectId = value; }
        public int StaffID { get => _staffId; set => _staffId = value; }
    }
}

