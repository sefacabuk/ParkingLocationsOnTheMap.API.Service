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
    public class NewIsparkDataManager : INewIsparkDataService
    {
        private INewIsparkDataRepository _newIsparkDataRepository;

        public NewIsparkDataManager(INewIsparkDataRepository newIsparkDataRepository)
        {
            _newIsparkDataRepository = newIsparkDataRepository;
        }

        public NewIsparkData CreateNewIsparkData(NewIsparkData newIspark)
        {
            return _newIsparkDataRepository.CreateNewIsparkData(newIspark);
        }

        public void DeleteNewIsparkData(int id)
        {
            _newIsparkDataRepository.DeleteNewIsparkData(id);
        }

        public List<NewIsparkData> GetAllNewIspark()
        {
            return _newIsparkDataRepository.GetAllNewIspark();
        }

        public NewIsparkData GetNewIsparkDataId(int id)
        {
            return _newIsparkDataRepository.GetNewIsparkDataId(id);
        }

        public NewIsparkData UpdateNewIsparkData(NewIsparkData newIspark)
        {
            return _newIsparkDataRepository.UpdateNewIsparkData(newIspark);
        }
    }
}
