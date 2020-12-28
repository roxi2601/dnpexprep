using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VolumeWebAPI.Model;
using VolumeWebAPI.VolumeWebService.VolumeCalculator;

namespace VolumeWebAPI.Controllers
{  
   
    [ApiController]
    [Route("[controller]")]
    public class VolumeController:ControllerBase
    {
        private Calculator calculator;
        private IVolumesService volumesService;

        public VolumeController(IVolumesService volumesService)
        {
            this.volumesService = volumesService;
        }
        
        public async Task<ActionResult<VolumeResult>> getCylinder(double x, double y)
        {
            try
            {
                Console.WriteLine("get cylinderrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
                return Ok(volumesService.GetCylinderAsync(x,y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        public async Task<ActionResult<VolumeResult>> getCone(double x, double y)
        {
            try
            {
                Console.WriteLine("get coneeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                return Ok(volumesService.GetConeAsync(x,y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [Route("/Volumes")]
        public async Task<ActionResult<IList<VolumeResult>>> GetVolumes()
        {
            try
            {
                Console.WriteLine("controllerrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr");
                return Ok(volumesService.GetVolumes());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<VolumeResult>> AddVolume([FromBody] VolumeResult volume)
        {
            Console.WriteLine("add");
            if (!ModelState.IsValid)
            {
                return StatusCode(400, "The data are not typed in correctly, specify height and radius");
            }
            try
            {
                VolumeResult added = await volumesService.AddVolumeAsync(volume);
                return Created($"/{added.Id}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

    }
}