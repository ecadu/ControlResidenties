using System.ComponentModel.DataAnnotations;

namespace Resident_Control.Model.Loja1
{
    public class Automakers
    {
        [Key]
        public int AutomakersId { get; set; }

        public string Name { get; set; }
    }
}
