using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StanadardData
    {
        public void SaveStandardData(StandardModel standardModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                Standard standard = new Standard();
                //standard.StandardID = standardModel.StandardID;
                //standard.StandardID = 4;
                standard.StandardName = standardModel.StandardName;
                studentManagementSystemEntities.Standards.Add(standard);
                studentManagementSystemEntities.SaveChanges();
                // MessageBox.Show("Value Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<StandardModel> GetStandardList()
        {
            StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
            var result = from getdata in studentManagementSystemEntities.Standards
                         select getdata;

            List<StandardModel> standardModels = new List<StandardModel>();
            foreach (var item in result)
            {
                StandardModel standardModel = new StandardModel();
                standardModel.StandardID = item.StandardID;
                standardModel.StandardName = item.StandardName;
                standardModels.Add(standardModel);
            }
            return standardModels;

        }
        public void UpdateStandardData(StandardModel standardModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                var query = from standardObj in studentManagementSystemEntities.Standards
                            where standardObj.StandardID == standardModel.StandardID
                            select standardObj;
                foreach (var entity in query)
                {
                    entity.StandardID = standardModel.StandardID;
                    entity.StandardName = standardModel.StandardName;
                }
                studentManagementSystemEntities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void DeleteStandardData(StandardModel standardModel)
        {
            try
            {
                StudentManagementSystemEntities entities = new StudentManagementSystemEntities();
                var result = from standardObj in entities.Standards
                             where standardObj.StandardID == standardModel.StandardID
                             select standardObj;
                foreach (var entity in result)
                {
                    entities.Standards.Remove(entity);
                }
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}