namespace Resident_Control.Model.DTO
{
    public class AssignVehicleToUser
    {
        public int ResidentieId { get; set; }
        public string Name { get; set; }

        public DateTime Year { get; set; }

        public double Price { get; set; }

        public string Color { get; set; }

        public int AutoMarkersId { get; set; }

        public string Plate { get; set;}


    }
}
