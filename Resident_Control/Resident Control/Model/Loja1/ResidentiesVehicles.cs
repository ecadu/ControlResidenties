using System.ComponentModel.DataAnnotations;

namespace Resident_Control.Model.Loja1
{
    public class ResidentiesVehicles
    {
        [Key]
        public int ResidentieId { get; set; }

        public int VehiclesId { get; set; }
    }
}
