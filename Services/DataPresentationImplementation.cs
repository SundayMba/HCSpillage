using HCSpillage.Dtos;
using HCSpillage.Models;

namespace HCSpillage.Services
{
    public class DataPresentationImplementation : IDataPresentation
    {
        private List<DataPresentation> Presentations = new List<DataPresentation>()
        {
            new DataPresentation() {
                Id = 1,
                DeviceId = "A123",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Uyo",
                Config = true
            },
            new DataPresentation() {
                Id = 2,
                DeviceId = "A223",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "Off",
                Verify = true,
                Location = "Abak",
                Config = false
            },
            new DataPresentation() {
                Id = 3,
                DeviceId = "A523",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "Off",
                Verify = true,
                Location = "Abak",
                Config = true
            },
            new DataPresentation() {
                Id = 4,
                DeviceId = "A423",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Oron",
                Config = false
            }
        };

        public DataPresentation CreateDevice(DataPresentation device)
        {
            Presentations.Add(device);
            return device;
        }

        public IEnumerable<DataPresentation> GetAllData()
        {
            return Presentations;
        }

        public List<DataPresentation> GetAllDataByDeviceId(string deviceId)
        {
            if (deviceId == null) throw new ArgumentNullException();
            return Presentations.Where(x => x.DeviceId == deviceId).ToList();
        }

        public IEnumerable<DataPresentation> GetAllDeviceByData()
        {
            return Presentations;
        }

        public DataPresentation GetDataByDeviceId(string deviceId)
        {
            if(deviceId == null) throw new ArgumentNullException(); 
            return Presentations.FirstOrDefault(x => x.DeviceId == deviceId);
        }

        public IEnumerable<DataPresentation> GetUnverifiedData()
        {
            return Presentations.Where(x => x.Verify != true).ToList();
        }

        public IEnumerable<DataPresentation> GetVerifiedData()
        {
            return Presentations.Where(x => x.Verify == true).ToList();
        }

        public void VerifyDevice(DataPresentation device)
        {
            throw new NotImplementedException();
        }
    }
}
