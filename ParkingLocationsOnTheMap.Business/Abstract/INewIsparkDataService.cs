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

        NewIsparkData CreateNewIsparkData(NewIsparkData ispark);

        NewIsparkData UpdateNewIsparkData(NewIsparkData ispark);

        void DeleteNewIsparkData(int id);
    }
}
