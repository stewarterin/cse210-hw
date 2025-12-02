public class Word
{
    private string _word;

    private bool _hidden; 

    public Word(string word)
    {
        _word = word;
        _hidden = ;
    }
    
    public void Hide()
    {
        _hidden = true; 
    }

    public string Show()
    {
        if (_hidden == true)
        {
            return ("_____");
        }
        else
        {
            return _word;
        }
    }

    public bool IsHidden()
    {
        return ;
    }

    public string GetWord()
    {
        return ;
    }
}