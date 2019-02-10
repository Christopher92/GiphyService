using System.Threading.Tasks;

namespace GiphyService.Services
{
    public interface IGiphyServices
    {
        void getsth();

        Task<string> GetRandomGifBasedOnSearchCriteria(string searchCriteria);
    }
}
