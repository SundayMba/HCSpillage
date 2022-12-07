
using HCSpillage.Models;

namespace HCSpillage.Services
{
    public interface IDataPresentation
    {
        public DataPresentation GetDataByDeviceId(string deviceId);
        public IEnumerable<DataPresentation> GetAllData();
        public IEnumerable<DataPresentation> GetAllDataByDeviceId(string deviceId);
        public IEnumerable<DataPresentation> GetVerifiedData();
        public IEnumerable<DataPresentation> GetUnverifiedData();
        
    }
}
