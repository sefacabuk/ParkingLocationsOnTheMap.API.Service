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
        List<NewIsparkData> GetAllNewIspark();

        NewIsparkData GetNewIsparkDataId(int id);

        NewIsparkData CreateNewIsparkData(NewIsparkData newNewIspark);

        NewIsparkData UpdateNewIsparkData(NewIsparkData newNewIspark);

        void DeleteNewIsparkData(int id);
    }
}
