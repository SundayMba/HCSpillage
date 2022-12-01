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
                Location = "Uyo"
            },
            new DataPresentation() {
                Id = 2,
                DeviceId = "A223",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "Off",
                Verify = true,
                Location = "Abak"
            },
            new DataPresentation() {
                Id = 3,
                DeviceId = "A523",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "Off",
                Verify = true,
                Location = "Abak"
            },
            new DataPresentation() {
                Id = 4,
                DeviceId = "A423",
                Data = "Gas detected",
                date = DateTime.UtcNow.ToShortDateString(),
                Time = DateTime.UtcNow.ToShortTimeString(),
                Status = "On",
                Verify = false,
                Location = "Oron"
            }
        };

        public void CreateDevice(DataPresentationDto device)
        {
            var newDevice = new DataPresentation()
            {
                Id = Presentations.Max(x => x.Id + 1),
                DeviceId = device.DeviceId,
                Location = device.Location,
                Time = DateTime.UtcNow.ToShortTimeString(),
                date = DateTime.UtcNow.ToShortDateString(),
            };
            Presentations.Add(newDevice);
        }

        public List<DataPresentation> GetAllData()
        {
            return Presentations;
        }

        public List<DataPresentation> GetAllDataByDeviceId(string deviceId)
        {
            if (deviceId == null) throw new ArgumentNullException();
            return Presentations.Where(x => x.DeviceId == deviceId).ToList();
        }

        public DataPresentation GetDataByDeviceId(string deviceId)
        {
            if(deviceId == null) throw new ArgumentNullException(); 
            return Presentations.FirstOrDefault(x => x.DeviceId == deviceId);
        }

        public List<DataPresentation> GetUnverifiedData()
        {
            return Presentations.Where(x => x.Verify != true).ToList();
        }

        public List<DataPresentation> GetVerifiedData()
        {
            return Presentations.Where(x => x.Verify == true).ToList();
        }
    }
}
