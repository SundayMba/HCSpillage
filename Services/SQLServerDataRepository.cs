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

        public IEnumerable<DataPresentation> GetAllData()
        {
            return dbContext.DeviceData.ToList() ;
        }

        public IEnumerable<DataPresentation> GetAllDataByDeviceId(string deviceId)
        {
           if(!string.IsNullOrEmpty(deviceId))
            {
                return dbContext.DeviceData.Where(device => device.DeviceId == deviceId);
            }
            return null;
        }

        public DataPresentation GetDataByDeviceId(string deviceId)
        {
            if(!string.IsNullOrEmpty(deviceId))
            {
                return dbContext.DeviceData.Find(deviceId);
            }

            return null;
             
        }

        public IEnumerable<DataPresentation> GetUnverifiedData()
        {
            return dbContext.DeviceData.Where(device => device.Verify != true);
        }

        public IEnumerable<DataPresentation> GetVerifiedData()
        {
            return dbContext.DeviceData.Where(device => device.Verify == true);
        }
    }
}
