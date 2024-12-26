using Microsoft.AspNetCore.Mvc;
using Resident_Control.Business.vehicles;
using Resident_Control.Model.DTO;
using Resident_Control.Model.Loja1;

namespace Resident_Control.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class VehiclesControll : ControllerBase
    {

        private readonly IVehiclesBusiness _vehiclesBusiness;

        public VehiclesControll(IVehiclesBusiness vehiclesBusiness)
        {
            _vehiclesBusiness = vehiclesBusiness;
        }



        [HttpGet("GetVehicles")]

        public IActionResult  GetVehicles( ) 
        {
            List<Model.Loja1.vehicles> vehiclesList = _vehiclesBusiness.GetVehicles();
            return Ok(vehiclesList); 

        }



        [HttpPost("AssignVehicleToUser")]

        public IActionResult AssignVehicleToUser(AssignVehicleToUser assignVehicleToUser)
        {
            if(assignVehicleToUser == null)
            {
                return BadRequest("Parametro Obrigatorio");
            }
            try
            {
                return Ok(_vehiclesBusiness.AssignVehicleToUser(assignVehicleToUser));
            }
            catch (Exception ex)
            { return BadRequest(ex.Message);}
        }


        [HttpDelete("RemoveUserVehicle")]
        public IActionResult RemoveUserVehicle(ResidentiesVehicles residentiesVehicles)
        {
            if (residentiesVehicles == null)
            {
                return NotFound();
            }
            try
            {
                return Ok(_vehiclesBusiness.RemoveUserVehicle(residentiesVehicles));
            }
            catch (Exception ex) { return BadRequest(); }


        }
    }
}
