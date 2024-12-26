namespace Resident_Control.Business.Residenties
{
    public interface IResidentiesBusiness
    {

        List<Data.Entities.Residenties> GetAllResidenties();


        bool AddResidenties(Model.Residenties.DTOResidenties Residenties);
        public bool UpdateResidentie(Data.Entities.Residenties residentie);

        public bool DeleteResidentieById(int id);
    }
}
