using Resident_Control.Model.Residenties;

namespace Resident_Control.Repository.Residenties
{
    public interface IResidentiesRepository
    {

        List<Data.Entities.Residenties> GetAllResidenties();

        dynamic AddResidenties(Data.Entities.Residenties Residenties);

        public bool UpdateResidentie(Data.Entities.Residenties residentie);

        Data.Entities.Residenties GetResidentieById(int id);

        public bool DeleteResidentie(Data.Entities.Residenties residentie);
    }
}
