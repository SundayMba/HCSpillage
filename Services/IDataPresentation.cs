
using HCSpillage.Models;

namespace HCSpillage.Services
{
    public interface IDataPresentation
    {
        public DataPresentation GetDataByDeviceId(string deviceId);
        public List<DataPresentation> GetAllData();
        public List<DataPresentation> GetAllDataByDeviceId(string deviceId);
        public IEnumerable<DataPresentation> GetVerifiedData();
        public IEnumerable<DataPresentation> GetUnverifiedData();
        public DataPresentation CreateDevice(DataPresentation device);
        public void VerifyDevice(DataPresentation device);
        public IEnumerable<DataPresentation> GetAllDeviceByData();


    }
}
