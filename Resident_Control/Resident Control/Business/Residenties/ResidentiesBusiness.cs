using Resident_Control.Data.Context;
using Resident_Control.Model.Residenties;
using Resident_Control.Repository.Residenties;

namespace Resident_Control.Business.Residenties
{
    public class ResidentiesBusiness : IResidentiesBusiness
    {

        private readonly MSSQLContext _context;
        private readonly IResidentiesRepository _residentiesRepository;

        public ResidentiesBusiness(MSSQLContext context, IResidentiesRepository residentiesRepository)
        {
            _context = context; 
            _residentiesRepository = residentiesRepository; 
        }

        public bool AddResidenties(DTOResidenties Residenties)
        {
            Data.Entities.Residenties residenties =  new Data.Entities.Residenties();

            residenties.Apartament = Residenties.Apartament;
            residenties.Block = Residenties.Block;
            residenties.DateOfBirth = Residenties.DateOfBirth;  
            residenties.CPF = Residenties.CPF;  
            residenties.Name = Residenties.Name;    
            return _residentiesRepository.AddResidenties(residenties);
        }

        public List<Data.Entities.Residenties> GetAllResidenties()
        {
            return _residentiesRepository.GetAllResidenties();
        }

        public bool UpdateResidentie(Data.Entities.Residenties residentie)
        {
            var residentieById = _residentiesRepository.GetResidentieById(residentie.ID);
            if (residentieById == null) 
            {
                return false;
            }
            else
            {
                residentieById.Apartament = residentie.Apartament;
                residentieById.DateOfBirth = residentie.DateOfBirth;
                residentieById.Name = residentie.Name;
                residentieById.Block = residentie.Block;
                residentieById.CPF = residentie.CPF;
                return _residentiesRepository.UpdateResidentie(residentieById);
                
            }
        }


        public bool DeleteResidentieById(int id)
        {
            var residentie = _residentiesRepository.GetResidentieById(id);
            if(residentie == null)
            {
                return false;
            }
            return _residentiesRepository.DeleteResidentie(residentie);
        }
    }
}
