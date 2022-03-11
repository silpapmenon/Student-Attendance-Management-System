using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AttendanceData
    {
        public List<StandardModel> GetStandard(StandardModel standardModel)
        {
            List<StandardModel> standardModels = new List<StandardModel>();

            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from standard in studentManagementSystemEntities.Standards
                         where standard.StandardID >= standardModel.StandardID
                         select standard;
            foreach (var std in result)
            {
                StandardModel standardModel1 = new StandardModel();
                standardModel1.StandardName = std.StandardName;
                standardModels.Add(standardModel1);
            }
            return standardModels;
        }
        public List<DivisionModel> GetDivision(DivisionModel divisionModel)
        {

            List<DivisionModel> divisionModels = new List<DivisionModel>();

            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result1 = from division in studentManagementSystemEntities.Divisions
                          where division.DivisionID >= divisionModel.DivisionID
                          select division;
            foreach (var div in result1)
            {
                DivisionModel divisionModel1 = new DivisionModel();
                divisionModel1.DivisionName = div.DivisionName;
                divisionModels.Add(divisionModel1);
            }
            return divisionModels;
        }
    }
}