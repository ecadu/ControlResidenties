using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Resident_Control.Business.Residenties;

namespace Resident_Control.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ResidentiesController : ControllerBase
    {
        private readonly IResidentiesBusiness _residentiesBusiness;

        public ResidentiesController(IResidentiesBusiness residentiesBusiness)
        {
            _residentiesBusiness = residentiesBusiness;
        }

        [HttpGet("GetAllResidenties")]

        public IActionResult GetAllResidenties()
        {
            try
            {
                return Ok(_residentiesBusiness.GetAllResidenties());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("AddResidenties")]

        public IActionResult AddResidenties(Model.Residenties.DTOResidenties Residenties)
        {
            try
            {
                return Ok(_residentiesBusiness.AddResidenties(Residenties).ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut("UpdateResidentie")]

        public IActionResult UpdateResidentie(Data.Entities.Residenties residentie)
        {
            if (residentie == null)
            {
                return BadRequest("Residentie não pode ser null");
            }
            try
            {
                return Ok("Resultado: " + _residentiesBusiness.UpdateResidentie(residentie));
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }

        }

        [HttpDelete("DeleteResidentieById")]
        public IActionResult DeleteResidentieById(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id Obrigatorio");
            }
            try
            {
                return Ok(_residentiesBusiness.DeleteResidentieById(id));
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }

        }
    }
}
