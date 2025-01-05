namespace Resident_Control.Business.Automakers
{
    public interface IAutomarksBusiness
    {
        bool CreateAutomark(string Automarks);

        public List<Model.Loja1.Automakers> GetAllAutomarks();

    }
}
