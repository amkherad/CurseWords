using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CurseWords
{
    public interface ICurseWordRepository
    {
        Task<IEnumerable<CurseWord>> GetAll(
            CancellationToken cancellationToken
        );
    }
}