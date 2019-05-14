using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Data;

namespace RTest.Controllers
{
    [Route("api/[controller]")]
    public class SliderController : Controller
    {
       
        private readonly IRepository<Slider> repository;

        public SliderController(IRepository<Slider> repository)
        {
            this.repository = repository;
        }

        [HttpGet("GetSlider")]
        public async Task<IActionResult> GetSlider()
        {
            IEnumerable<Slider> sliders = await repository.Get(x=> x.PanelType == 3);
            List<Slider> slidersData = sliders.ToList();
            return Ok(slidersData);
        }
    }
}