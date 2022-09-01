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
        List<IsparkData> GetAllIspark();

        IsparkData GetIsparkDataId(int id);

        IsparkData CreateIsparkData(IsparkData ispark);

        IsparkData UpdateIsparkData(IsparkData ispark);

        void DeleteIsparkData(int id);
    }
}
