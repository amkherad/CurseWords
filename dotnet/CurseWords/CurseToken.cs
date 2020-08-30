namespace CurseWords
{
    public struct CurseToken
    {
        public int StartIndex { get; }
        
        public int EndIndex { get; }


        public CurseToken(
            int startIndex,
            int endIndex
        )
        {
            StartIndex = startIndex;
            EndIndex = endIndex;
        }
    }
}