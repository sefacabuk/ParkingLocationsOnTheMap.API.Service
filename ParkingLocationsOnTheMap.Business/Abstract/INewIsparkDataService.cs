using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Business.Abstract
{
    public interface INewIsparkDataService
    {
        List<NEW_ISPARK_DATA> GetAllNewIspark();

        NEW_ISPARK_DATA GetNewIsparkDataId(int id);

        NEW_ISPARK_DATA CreateNewIsparkData(NEW_ISPARK_DATA newNewIspark);

        NEW_ISPARK_DATA UpdateNewIsparkData(NEW_ISPARK_DATA newNewIspark);


        void DeleteNewIsparkData(int id);
        //NEW_ISPARK_DATA UpdateIsparkAllData(NEW_ISPARK_DATA newNewIspark);
    }
}
