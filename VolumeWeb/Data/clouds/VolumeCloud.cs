using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using VolumeWeb.Model;
namespace VolumeWeb.Data.clouds
{
    public class VolumeCloud: IVolumesService
    {
        HttpClient client = new HttpClient();
        public async Task<IList<VolumeResult>> GetConeAsync(double x, double y)
        {
            string message = await client.GetStringAsync("https://localhost:5002/cone?height="+x+"radius="+y);
            List<VolumeResult> result = JsonSerializer.Deserialize<List<VolumeResult>>(message);
            return result;
        }
        public async Task<IList<VolumeResult>> GetCylinderAsync(double x, double y)
        {
            string message = await client.GetStringAsync("https://localhost:5002/cylinder?height="+x+"radius="+y);
            List<VolumeResult> result = JsonSerializer.Deserialize<List<VolumeResult>>(message);
            return result;
        }

        public async Task AddVolumeAsync(VolumeResult volumeResult)
        {
            string volumeSerialized = JsonSerializer.Serialize(volumeResult);
            StringContent content = new StringContent(volumeSerialized,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await client.PostAsync("https://localhost:5002/Volumes",content);
            Console.WriteLine(response.ToString());
            if (response.StatusCode != HttpStatusCode.Created)
            {
                throw new HttpRequestException(response.Content.ReadAsStringAsync().Result);
            }
        }

        public async Task<IList<VolumeResult>> GetVolumes()
        {
            string message = await client.GetStringAsync("https://localhost:5002/Volumes");
            Console.WriteLine(message);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //Console.WriteLine(JsonSerializer.Deserialize(message,List<VolumeResult>.Enumerator);
            IList<VolumeResult> result = JsonSerializer.Deserialize<List<VolumeResult>>(message);
            
        
            return result;
        }
    }
}