using ParkingLocationsOnTheMap.Business.Abstract;
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
        private IsparkDataRepository _isparkDataRepository;

        public IsparkDataManager()
        {
            _isparkDataRepository = new IsparkDataRepository();
        }

        public IsparkData CreateIsparkData(IsparkData ispark)
        {
            return _isparkDataRepository.CreateIsparkData(ispark);
        }

        public void DeleteIsparkData(int id)
        {
            _isparkDataRepository.DeleteIsparkData(id);
        }

        public List<IsparkData> GetAllIspark()
        {
            return _isparkDataRepository.GetAllIspark();
        }

        public IsparkData GetIsparkDataId(int id)
        {
            return _isparkDataRepository.GetIsparkDataId(id);
        }

        public IsparkData UpdateIsparkData(IsparkData ispark)
        {
            return _isparkDataRepository.UpdateIsparkData(ispark);
        }
    }
}
