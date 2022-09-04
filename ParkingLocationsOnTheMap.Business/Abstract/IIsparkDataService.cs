using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Business.Abstract
{
    public interface IIsparkDataService
    {
        List<ISPARK_DATA> GetAllIspark();

        ISPARK_DATA GetIsparkDataId(int id);

        ISPARK_DATA CreateIsparkData(ISPARK_DATA ispark);

        ISPARK_DATA UpdateIsparkData(ISPARK_DATA ispark);

        void DeleteIsparkData(int id);
    }
}
