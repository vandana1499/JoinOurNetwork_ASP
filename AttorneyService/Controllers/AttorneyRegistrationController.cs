using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modal;
using AttorneyService.BusinessLayer;

namespace AttorneyService.API.Controllers
{
    [ApiController]
    [Route("attorney-registration")]
    public class AttorneyRegistrationController : Controller
    {

        public IAttorneyOperation IAtr;
        public AttorneyRegistrationController(IAttorneyOperation attorneyOperation)
        {
            IAtr = attorneyOperation;
        }

        [HttpGet]
        [Route("getAllProfiles")]
        public ActionResult<List<Attorney>> getAllProfiles()
        {
            return Ok(IAtr.getAllProfiles());
        }

        [HttpPost]
        [Route("create-profile")]
        public void createProfile([FromBody] Attorney ATSObj)
        {
            IAtr.createProfile(ATSObj); 
        }

        //[HttpPut]
        //[Route("edit-profile/{id ?}")]
        //public void editProfile(int? id,[FromBody] Attorney ATSObj)
        //{

        //}





    }
}
