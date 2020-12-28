using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dnpexprep.VolumeWebService.VolumeCalculator
{  
    [Route("/[controller]")]
    [ApiController]
    public class Controller:ControllerBase
    {
        private Calculator calculator;
        private IVolumesService volumesService;

        public Controller(IVolumesService volumesService)
        {
            this.volumesService = volumesService;
        }

        [HttpGet]
        public async Task<ActionResult<VolumeResult>> getCylinder(double x, double y)
        {
            try
            {
                return Ok(volumesService.GetCylinderAsync(x,y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        public async Task<ActionResult<VolumeResult>> getCone(double x, double y)
        {
            try
            {
                return Ok(volumesService.GetConeAsync(x,y));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IList<VolumeResult>>> GetVolumes()
        {
            try
            {
                
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