using System.Threading;
using System.Threading.Tasks;

namespace CurseWords
{
    public interface ICurseWordServiceFactory
    {
        Task<ICurseWordService> Create(
            CancellationToken cancellationToken
        );
    }
}