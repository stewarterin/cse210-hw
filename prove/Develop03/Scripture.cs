public class Scripture
{
    private string _reference;
    private List<Word> _words; 

    public Scripture(string reference, string scripture)
    {
        _reference = reference;

        string[] splitScripture = scripture.Split(' ');
        _words = new List<Word>();
        foreach (string word in splitScripture)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords()
    {
        List<Word> showWords = new List<Word>();

        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                showWords.Add(word);
            }
        }
    }

    public void GetText()
    {
        
    } 

    public bool IsCompletelyHidden() //Problem here. Method needs to return bool outside of the if/else loop..
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        
    }

    // public string DisplayText()
    // {
        
    // }
}