using DataAccessLayer;
using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StandardManager
    {
        public void SaveStandardDetails(StandardModel standardModel)
        {
            StanadardData standardData = new StanadardData();
            standardData.SaveStandardData(standardModel);
        }
        public List<StandardModel> DisplayResult()
        {
            StanadardData standardData = new StanadardData();
            return standardData.GetStandardList();
        }
    }
}
