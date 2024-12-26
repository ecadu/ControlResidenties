using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Resident_Control.Data.Entities
{
    public class Residenties
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CPF { get; set; }

        public int Block { get; set; }

        public int Apartament { get; set; }
    }
}
