public class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int verseEnd;

    public Reference(string book, int chapter, int verseStart)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseStart; // Single verse
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd; // Verse range
    }

    public override string ToString()
    {
        return verseStart == verseEnd 
            ? $"{book} {chapter}:{verseStart}" 
            : $"{book} {chapter}:{verseStart}-{verseEnd}";
    }
}