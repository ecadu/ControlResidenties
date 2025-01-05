using Microsoft.AspNetCore.Mvc;
using Resident_Control.Business.Automakers;
using Resident_Control.Model.DTO;
using Resident_Control.Repository.Automakers;

namespace Resident_Control.Controllers
{
    public class AutomarksController : ControllerBase
    {

        private readonly Business.Automakers.IAutomarksBusiness _automarksBusiness;

        public AutomarksController(IAutomarksBusiness automarksBusiness)
        {
            _automarksBusiness = automarksBusiness;
        }





        [HttpPost("CreateAutomark")]

        public IActionResult CreateAutomark(string AutomarksName)
        {

            try
            {

                return Ok(_automarksBusiness.CreateAutomark(AutomarksName));
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);  
            
            }

        }


        [HttpGet("GetAllAutomarks")]

        public IActionResult GetAllAutomarks()
        {

            try
            {

                return Ok(_automarksBusiness.GetAllAutomarks());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }

        }


    }
}
