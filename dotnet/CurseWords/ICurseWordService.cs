using System;
using System.Threading;

namespace CurseWords
{
    public interface ICurseWordService
    {
        CurseToken[] AnalyzeText(
            string buffer,
            CancellationToken cancellationToken
        );
        
        CurseToken[] AnalyzeText(
            ReadOnlySpan<char> buffer,
            CancellationToken cancellationToken
        );
    }
}