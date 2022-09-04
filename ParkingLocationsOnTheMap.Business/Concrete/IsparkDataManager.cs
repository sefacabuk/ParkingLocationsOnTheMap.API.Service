using ParkingLocationsOnTheMap.Business.Abstract;
using ParkingLocationsOnTheMap.DataAccess.Abstract;
using ParkingLocationsOnTheMap.DataAccess.Concrete;
using ParkingLocationsOnTheMap.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLocationsOnTheMap.Business.Concrete
{
    public class IsparkDataManager : IIsparkDataService
    {
        private IIsparkDataRepository _isparkDataRepository;

        public IsparkDataManager(IIsparkDataRepository isparkDataRepository)
        {
            _isparkDataRepository = isparkDataRepository;
        }

        public ISPARK_DATA CreateIsparkData(ISPARK_DATA ispark)
        {
            return _isparkDataRepository.CreateIsparkData(ispark);
        }

        public void DeleteIsparkData(int id)
        {
            _isparkDataRepository.DeleteIsparkData(id);
        }

        public List<ISPARK_DATA> GetAllIspark()
        {
            return _isparkDataRepository.GetAllIspark();
        }

        public ISPARK_DATA GetIsparkDataId(int id)
        {
            return _isparkDataRepository.GetIsparkDataId(id);
        }

        public ISPARK_DATA UpdateIsparkData(ISPARK_DATA ispark)
        {
            return _isparkDataRepository.UpdateIsparkData(ispark);
        }
    }
}
