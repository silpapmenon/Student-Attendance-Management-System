using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DivisionManager
    {
        public void SaveDivisionDetails(DivisionModel divisionModel)
        {
            DivisionData divisionData = new DivisionData();
            divisionData.SaveDivisionData(divisionModel);
        }
        public List<DivisionModel> DisplayResult()
        {
            DivisionData divisionData = new DivisionData();
            return divisionData.GetDivisionData();
        }
        public void UpdateData(DivisionModel divisionModel)
        {
            DivisionData divisionData = new DivisionData();
            divisionData.UpdateDivisionData(divisionModel);
        }
        public void DeleteDivisionDetails(DivisionModel divisionModel)
        {
            DivisionData divisionData = new DivisionData();
            divisionData.DeleteDivisionData(divisionModel);
        }
    }
}
