using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using VolumeWebAPI.Model;
using VolumeWebAPI.VolumeWebService.VolumeCalculator;

namespace VolumeWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (Context context = new Context())
            {
                if (!context.volumes.Any())
                {
                    VolumesSeed(context);
                }
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        
        private static void VolumesSeed(Context context)
        {
            string volumesFile = "volumes.json";
            IList<VolumeResult> results;
            
            if (!File.Exists(volumesFile))
            {
                throw new Exception("File volumes.json does not exist");
            }
            else
            {
                string content = File.ReadAllText(volumesFile);
                results = JsonSerializer.Deserialize<List<VolumeResult>>(content);
                //results.First();
            }

            Console.WriteLine(results[1].ToString());
            foreach (var result in results)
            {
                Console.WriteLine(result.Id);
                context.volumes.Add(result);
            }

            context.SaveChanges();
        }
    }
}