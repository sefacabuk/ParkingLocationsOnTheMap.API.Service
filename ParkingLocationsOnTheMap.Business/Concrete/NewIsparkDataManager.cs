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

        public NEW_ISPARK_DATA CreateNewIsparkData(NEW_ISPARK_DATA newIspark)
        {
            return _newIsparkDataRepository.CreateNewIsparkData(newIspark);
        }
       
        public void DeleteNewIsparkData(int id)
        {
            _newIsparkDataRepository.DeleteNewIsparkData(id);
        }

        public List<NEW_ISPARK_DATA> GetAllNewIspark()
        {
            return _newIsparkDataRepository.GetAllNewIspark();
        }

        public NEW_ISPARK_DATA GetNewIsparkDataId(int id)
        {
            return _newIsparkDataRepository.GetNewIsparkDataId(id);
        }

        public NEW_ISPARK_DATA UpdateNewIsparkData(NEW_ISPARK_DATA newIspark)
        {
            return _newIsparkDataRepository.UpdateNewIsparkData(newIspark);
        }

        //public NEW_ISPARK_DATA UpdateIsparkAllData(NEW_ISPARK_DATA newIspark)
        //{
        //    return _newIsparkDataRepository.CreateNewIsparkData(newIspark);
        //}

    }
}
