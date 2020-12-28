using System.Collections.Generic;
using System.Threading.Tasks;

namespace dnpexprep.VolumeWebService.VolumeCalculator
{
    public interface IVolumesService
    {
        Task<IList<VolumeResult>> GetConeAsync(double x, double y);
        Task<IList<VolumeResult>> GetCylinderAsync(double x, double y);
        Task<VolumeResult>   AddVolumeAsync(VolumeResult volumeResult);

        Task<IList<VolumeResult>> GetVolumes();
    }
}