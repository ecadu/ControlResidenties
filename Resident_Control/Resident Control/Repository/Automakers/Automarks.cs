using Resident_Control.Data.Context;

namespace Resident_Control.Repository.Automakers
{
    public class Automarks : IAutomarkers
    {

        private readonly MSSQLContext _context;

        public Automarks(MSSQLContext context)
        {
            _context = context; 
        }
        public bool CreateAutomark(Model.Loja1.Automakers  AutomanrkName)
        {

            _context.Automakers.Add(AutomanrkName);
            var afectRows = _context.SaveChanges();
            return afectRows > 0;


        }

        public List<Model.Loja1.Automakers> GetAllAutomarks() 
        {
            return _context.Automakers.OrderBy(n=> n.Name).ToList();           
        }
    }
}
