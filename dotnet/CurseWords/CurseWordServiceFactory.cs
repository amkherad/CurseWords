using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CurseWords
{
    public class CurseWordServiceFactory : ICurseWordServiceFactory
    {
        private static CurseWord[] _curseWords;
        private static readonly SemaphoreSlim InitializeSemaphore = new SemaphoreSlim(1, 1);

        
        public ICurseWordRepository Repository { get; }


        public CurseWordServiceFactory(
            ICurseWordRepository repository
        )
        {
            Repository = repository;
        }


        public async Task<ICurseWordService> Create(
            CancellationToken cancellationToken
        )
        {
            if (!(_curseWords is null))
            {
                return new CurseWordService(_curseWords);
            }


            await InitializeSemaphore.WaitAsync(cancellationToken);
            try
            {
                var tokens = await Repository.GetAll(cancellationToken);
                
                _curseWords = tokens.ToArray();
                
                return new CurseWordService(_curseWords);
            }
            finally
            {
                InitializeSemaphore.Release();
            }
        }
    }
}