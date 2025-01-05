namespace Resident_Control.Repository.Automakers
{
    public interface IAutomarkers
    {

        bool CreateAutomark(Model.Loja1.Automakers AutomanrkName);
        public List<Model.Loja1.Automakers> GetAllAutomarks();
    }
}
