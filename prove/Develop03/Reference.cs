public class Reference
{
    // Here are my attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Here are my constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;

    }
    public Reference(string book, int chapter, int startVerse, int endVerse )
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Here are my methods
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}