public class Scripture
{
    private Reference _reference;
    private List<Word> _words; 

    public Scripture(Reference reference, string scripture)
    {
        _reference = reference;

        _words = new List<Word>();
        string[] splitScripture = scripture.Split(" ");
        foreach (string word in splitScripture)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords()
    {
        List<Word> _showWords = new List<Word>();

        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                _showWords.Add(word);
            }
        }

        Random random = new Random();
        int index = random.Next(_showWords.Count);
        _showWords[index].Hide(); 

    }

    public string GetText()
    {
        string _text = _reference.GetReference();
        
        foreach (Word word in _words)
        {
            _text = $"{_text}{word.Show()} ";
        }

        return _text;
    } 

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
            return true;
        

    }
}