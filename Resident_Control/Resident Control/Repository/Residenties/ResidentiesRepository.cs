using Resident_Control.Data.Context;
using Resident_Control.Model.Residenties;

namespace Resident_Control.Repository.Residenties
{
    public class ResidentiesRepository : IResidentiesRepository
    {

        private readonly MSSQLContext _context;

        public ResidentiesRepository(MSSQLContext context)
        {
            _context = context;
        }

        public dynamic AddResidenties(Data.Entities.Residenties Residenties)
        {
            try
            {
                _context.Add(Residenties);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public List<Data.Entities.Residenties> GetAllResidenties()
        {
            return _context.Residenties.ToList();
        }

        public Data.Entities.Residenties GetResidentieById(int id)
        {
            return _context.Residenties.FirstOrDefault( r=> r.ID == id);
        }

        public bool UpdateResidentie(Data.Entities.Residenties residentie)
        {
            _context.Residenties.Update(residentie);
            var afectRows = _context.SaveChanges();
            return afectRows > 0;

        }


        public bool DeleteResidentie(Data.Entities.Residenties residentie)
        {   
             
            _context.Residenties.Remove(residentie);
            var rowsAffects = _context.SaveChanges();
            return rowsAffects > 0;
        }
    }
}
