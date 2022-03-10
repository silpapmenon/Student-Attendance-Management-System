using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DivisionData
    {
        public void SaveDivisionData(DivisionModel divisionModel)
        {
            try
            {
                StudentManagementSystemEntities studentManagementSystemEntities = new StudentManagementSystemEntities();
                Division division = new Division();

                division.StandardID = divisionModel.StandardID;
                division.DivisionName = divisionModel.DivisionName;
                division.Seat = divisionModel.Seat;

                studentManagementSystemEntities.Divisions.Add(division);
                studentManagementSystemEntities.SaveChanges();
                //MessageBox.Show("Value Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DivisionModel> GetDivisionData()
        {
            StudentManagementSystemEntities entities = new StudentManagementSystemEntities();
            var result = from divisionObj in entities.Divisions
                         select divisionObj;
            List<DivisionModel> divisionModels = new List<DivisionModel>();
            foreach (var item in result)
            {
                DivisionModel model = new DivisionModel();
                model.StandardID = item.StandardID;
                model.DivisionName = item.DivisionName;
                model.Seat = item.Seat;

                divisionModels.Add(model);
            }
            return divisionModels;
        }
        public void UpdateDivisionData(DivisionModel divisionModel)
        {
            try
            {
                StudentManagementSystemEntities divisions = new StudentManagementSystemEntities();
                var query = from divisionObj in divisions.Divisions
                            where divisionObj.StandardID == divisionModel.StandardID
                            select divisionObj;
                foreach (var entity in query)
                {
                    entity.StandardID = divisionModel.StandardID;
                    entity.DivisionName = divisionModel.DivisionName;
                    entity.Seat = divisionModel.Seat;

                }
                divisions.SaveChanges();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void DeleteDivisionData(DivisionModel divisionModel)
        {
            try
            {
                StudentManagementSystemEntities entities = new StudentManagementSystemEntities();
                var result = from divisionObj in entities.Divisions
                             where divisionObj.StandardID == divisionModel.StandardID
                             select divisionObj;
                foreach (var entity in result)
                {
                    entities.Divisions.Remove(entity);
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
