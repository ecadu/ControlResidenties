using System.ComponentModel.DataAnnotations;

namespace Resident_Control.Model.Loja1
{
    public class vehicles
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Year { get; set; }

        public double  Price { get; set; }

        public string Color { get; set; }

        public int AutoMarkersId { get; set; }

        public string Plate {  get; set; }  
    }
}
