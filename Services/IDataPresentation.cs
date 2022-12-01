using HCSpillage.Dtos;
using HCSpillage.Models;

namespace HCSpillage.Services
{
    public interface IDataPresentation
    {
        public DataPresentation GetDataByDeviceId(string deviceId);
        public List<DataPresentation> GetAllData();
        public List<DataPresentation> GetAllDataByDeviceId(string deviceId);
        public List<DataPresentation> GetVerifiedData();
        public List<DataPresentation> GetUnverifiedData();
        public void CreateDevice(DataPresentationDto device);
    }
}
