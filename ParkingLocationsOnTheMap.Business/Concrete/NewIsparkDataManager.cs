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
    public class NewIsparkDataManager : INewIsparkDataService
    {
        private NewIsparkDataRepository _isparkDataRepository;

        public NewIsparkDataManager()
        {
            _isparkDataRepository = new NewIsparkDataRepository();
        }

        public NewIsparkData CreateNewIsparkData(NewIsparkData ispark)
        {
            return _isparkDataRepository.CreateNewIsparkData(ispark);
        }

        public void DeleteNewIsparkData(int id)
        {
            _isparkDataRepository.DeleteNewIsparkData(id);
        }

        public List<NewIsparkData> GetAllNewIspark()
        {
            return _isparkDataRepository.GetAllNewIspark();
        }

        public NewIsparkData GetNewIsparkDataId(int id)
        {
            return _isparkDataRepository.GetNewIsparkDataId(id);
        }

        public NewIsparkData UpdateNewIsparkData(NewIsparkData ispark)
        {
            return _isparkDataRepository.UpdateNewIsparkData(ispark);
        }
    }
}
