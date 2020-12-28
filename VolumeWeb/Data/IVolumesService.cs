using System.Collections.Generic;
using System.Threading.Tasks;
using VolumeWeb.Model;

namespace VolumeWeb.Data
{
    public interface IVolumesService
    {
        Task<IList<VolumeResult>> GetConeAsync(double x, double y);
        Task<IList<VolumeResult>> GetCylinderAsync(double x, double y);
        Task   AddVolumeAsync(VolumeResult volumeResult);
        Task<IList<VolumeResult>> GetVolumes();
    }
}