using HCSpillage.Data;
using HCSpillage.Dtos;
using HCSpillage.Models;
using Microsoft.EntityFrameworkCore;

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

        public List<DataPresentation> GetAllData()
        {
            var DataCollection = dbContext.DeviceData.ToList();
            DataCollection = DataCollection.OrderByDescending(data => data.Id).ToList();
            return DataCollection;
        }

        public List<DataPresentation> GetAllDataByDeviceId(string deviceId)
        {
           if(!string.IsNullOrEmpty(deviceId))
            {
                var datas =  dbContext.DeviceData.Where(device => device.DeviceId == deviceId).ToList();
                return datas = datas.OrderByDescending(data => data.Id).ToList();
            }
            return null;
        }

        public IEnumerable<DataPresentation> GetAllDeviceByData()
        {
            var data = dbContext.DeviceData.ToList();
            data = data.OrderByDescending(data => data.Id).ToList();
            return data;
        }

        public DataPresentation GetDataByDeviceId(string deviceId)
        {
            
            return dbContext.DeviceData.FirstOrDefault(d => d.DeviceId == deviceId);
             
        }

        public IEnumerable<DataPresentation> GetUnverifiedData()
        {
           var  Data =  dbContext.DeviceData.Where(device => device.Verify != true);
            return Data = Data.OrderByDescending(data => data.Id);
        }

        public IEnumerable<DataPresentation> GetVerifiedData()
        {
            var data =  dbContext.DeviceData.Where(device => device.Verify == true);
            return data.OrderByDescending(data => data.Id);
        }

        public void VerifyDevice(DataPresentation device)
        {
            var deviceId = GetDataByDeviceId(device.DeviceId);
            device.Verify = true;
        }
    }
}
