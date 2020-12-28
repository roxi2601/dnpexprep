using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using VolumeWebAPI.Model;

namespace VolumeWebAPI.VolumeWebService.VolumeCalculator
{
    public class VolumesService: IVolumesService
    {
        private string volumesFile = "volumes.json";
        private Calculator calculator;
        private IList<VolumeResult> results;
        public VolumesService()
        {
            if (!File.Exists(volumesFile))
            {
                Seed();
                WriteVolumesToFile();
            }
            else
            {
                string content = File.ReadAllText(volumesFile);
                results = JsonSerializer.Deserialize<List<VolumeResult>>(content);
               
            }
             Console.WriteLine(results.ToString());
            
        }
        public async Task<IList<VolumeResult>> GetConeAsync(double x, double y)
        {
         
                double coneVolume =  calculator.CalculateVolumeCone(y, x);
                /*VolumeResult result = new VolumeResult();
                result.Height = x;
                result.Radius = y;
                result.Type = "cone";
                result.Volume = coneVolume;
                results.Add(result);*/
                return results;
        }
        
        public async Task<IList<VolumeResult>> GetCylinderAsync(double x, double y)
        {
         
            double cylinderVolume =  calculator.CalculateVolumeCylinder(y, x);
            /*VolumeResult result = new VolumeResult();
            result.Height = x;
            result.Radius = y;
            result.Type = "cylinder";
            result.Volume = cylinderVolume;
            results.Add(result);*/
            return results;
        }
        public async Task<VolumeResult> AddVolumeAsync(VolumeResult volumeResult)
        {
            int max = results.Max(volume => volume.Id);
            volumeResult.Id = (++max);
            results.Add(volumeResult);
            WriteVolumesToFile();
            return volumeResult;
        }

        public async Task<IList<VolumeResult>> GetVolumes()
        {
            List<VolumeResult> tmp = new List<VolumeResult>();
            tmp = results.ToList();
            return tmp;
        }

        private void WriteVolumesToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(results);
            File.WriteAllText(volumesFile, productsAsJson);
        }
        
        private void Seed()
        {
            VolumeResult[] tmp =
            {
                new VolumeResult
                {
                    Type = "cone",
                    Height = 2,
                    Radius = 4,
                    Volume = 5
                }
                
            };
            results = tmp.ToList();
        }
    }
}