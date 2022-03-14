using EntityLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Interface
{
    public interface IStaffDetails
    {
        void UpdateStudentData(StaffModel staffModel);
        List<StaffModel> GetAllDetails(StaffModel staffModel);

    }
}
