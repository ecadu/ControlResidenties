
namespace Resident_Control.Business.Automakers
{
    public class AutomarksBusiness : IAutomarksBusiness
    {

        public readonly Repository.Automakers.IAutomarkers _automarksRepository;

        public AutomarksBusiness(Repository.Automakers.IAutomarkers automarksRepository)
        {
            _automarksRepository = automarksRepository;
        }

        public bool CreateAutomark(string Automarks)
        {

            var automarks = new Model.Loja1.Automakers()
            {
                Name = Automarks,
            };
            return _automarksRepository.CreateAutomark(automarks);
        }

        public List<Model.Loja1.Automakers> GetAllAutomarks()
        {
            return _automarksRepository.GetAllAutomarks();
        }
    }
}
