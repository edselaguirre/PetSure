using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PetSure.API.Model;

namespace PetSure.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetInfoController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<PetInfo> petInfoList = new List<PetInfo>();


            var defaultPetInfo = new PetInfo();
            petInfoList.Add(new PetInfo { Id = 1, Name = "Rover" });
            petInfoList.Add(new PetInfo { Id = 2, Name = "Fideo" });
            petInfoList.Add(new PetInfo { Id = 3, Name = "Pixie" });

            defaultPetInfo = new PetInfo()
            {
                Id = 1
               ,
                Name = "Rover"
            };

            return Ok(new
            {
                petinfo = petInfoList
                ,
                defPetInfo = defaultPetInfo
            });
        }

    }

    
}
