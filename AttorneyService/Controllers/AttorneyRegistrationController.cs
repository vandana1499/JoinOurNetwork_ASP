﻿using Microsoft.AspNetCore.Http;
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
        public ActionResult<Attorney> getAllProfiles()
        {
            return Ok(IAtr.getAllProfiles());
        }

        [HttpGet]
        [Route("getAllProfiles/{city?}")]
        public ActionResult<Attorney> getAllProfilesByCity(string ? city)
        {
            return Ok(IAtr.getAllProfilesByCity(city));
        }

        [HttpGet]
        [Route("getAllProfilesByDistinctCity")]
        public ActionResult<Attorney> getAllProfilesByDistinctCity()
        {
            return Ok(IAtr.getAllProfilesByDistinctCity());
        }


        [HttpPost]
        [Route("create-profile")]
        public ActionResult<Attorney> createProfile([FromBody] Attorney ATSObj)
        {
            var obj = IAtr.createProfile(ATSObj);
            return Ok(obj); 
        }

        //[Http]
        //[Route("getAllProfiles/{city?}")]
        //public ActionResult<Attorney> getAllProfilesByCity(string? city)
        //{
        //    return Ok(IAtr.getAllProfilesByCity(city));
        //}


        [HttpPut]
        [Route("update-profile/{id?}")]
        public ActionResult<AttorneyEntities> UpdateProfileByID([FromBody] AttorneyPUT ATSObj,int? id)
        {
            var obj = IAtr.updateProfileByID(ATSObj,Convert.ToInt32(id));
            return Ok(obj);
        }

        [HttpDelete]
        [Route("delete-profile/{id?}")]
        public string DeleteProfileByID(int? id)
        {
            IAtr.DeleteProfileByID(Convert.ToInt32(id));
            return "Successfully deleted";
        }




    }
}
