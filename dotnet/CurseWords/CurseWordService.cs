using System;
using System.Threading;

namespace CurseWords
{
    internal class CurseWordService : ICurseWordService
    {
        public CurseWord[] CurseWords { get; }
        
        public CurseWordService(
            CurseWord[] curseWords
        )
        {
            CurseWords = curseWords;
        }
        
        public CurseToken[] AnalyzeText(
            string buffer,
            CancellationToken cancellationToken
        )
        {
            throw new NotImplementedException();
        }

        public CurseToken[] AnalyzeText(
            ReadOnlySpan<char> buffer,
            CancellationToken cancellationToken
        )
        {
            throw new NotImplementedException();
        }
    }
}