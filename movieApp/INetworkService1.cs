using System.Threading.Tasks;

namespace movieApp
{
    public interface INetworkService1
    {
        Task<TResult> GetAsync<TResult>(string uri);
    }
}