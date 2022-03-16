using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
                //division.DivisionID = divisionModel.DivisionID;
                division.StandardName = divisionModel.StandardName;
                division.DivisionName = divisionModel.DivisionName;
                division.Seat = divisionModel.Seat;

                studentManagementSystemEntities.Divisions.Add(division);
                studentManagementSystemEntities.SaveChanges();
                MessageBox.Show("Value Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<DivisionModel> GetDivisionData()
        {
            StudentManagementSystemEntities entities = new StudentManagementSystemEntities();
            var result = entities.Divisions.Select(entity => entity);
            List<DivisionModel> divisionModels = new List<DivisionModel>();
            foreach (var item in result)
            {
                DivisionModel model = new DivisionModel();
                model.DivisionID = item.DivisionID;
                model.StandardName = item.StandardName;
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
                var query = divisions.Divisions.Where(x => x.DivisionID == divisionModel.DivisionID);
                foreach (var entity in query)
                {
                    entity.DivisionID = divisionModel.DivisionID;
                    entity.StandardName= divisionModel.StandardName;
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
                var query = entities.Divisions.Where(x => x.DivisionID == divisionModel.DivisionID);
                foreach (var entity in query)
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
