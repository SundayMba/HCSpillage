using HCSpillage.Data;
using HCSpillage.Dtos;
using HCSpillage.Models;

namespace HCSpillage.Services
{
    public class SQLServerDataRepository : IDataPresentation
    {
        private readonly AppDbContext dbContext;

        public SQLServerDataRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public DataPresentation CreateDevice(DataPresentation device)
        {
            dbContext.DeviceData.Add(device);
            dbContext.SaveChanges();
            return device;
        }

        public IEnumerable<DataPresentation> GetAllData()
        {
            var DataCollection = dbContext.DeviceData.Where(x => x.Data == "Yes").ToList();
            return DataCollection;
        }

        public List<DataPresentation> GetAllDataByDeviceId(string deviceId)
        {
           if(!string.IsNullOrEmpty(deviceId))
            {
                return dbContext.DeviceData.Where(device => device.DeviceId == deviceId).ToList();
            }
            return null;
        }

        public IEnumerable<DataPresentation> GetAllDeviceByData()
        {
            var data = dbContext.DeviceData.ToList();
            return data;
        }

        public DataPresentation GetDataByDeviceId(string deviceId)
        {
            
            return dbContext.DeviceData.FirstOrDefault(d => d.DeviceId == deviceId);
             
        }

        public IEnumerable<DataPresentation> GetUnverifiedData()
        {
            return dbContext.DeviceData.Where(device => device.Verify != true);
        }

        public IEnumerable<DataPresentation> GetVerifiedData()
        {
            return dbContext.DeviceData.Where(device => device.Verify == true);
        }

        public void VerifyDevice(DataPresentation device)
        {
            var deviceId = GetDataByDeviceId(device.DeviceId);
            device.Verify = true;
        }
    }
}
