public class RandomActivity
{
    private List<int> _activityNumbers = new List<int>
    {
        1, 2, 3
    };
    
    public void RunRandomActivity()
    {
        int _activityNumber = GetRandomActivity();
        
        if (_activityNumber == 1)
        {
            BreathingActivity b1 = new BreathingActivity();
            b1.RunBreathing();
        }
        else if (_activityNumber == 2)
        {
            ReflectingActivity r1 = new ReflectingActivity();
            r1.RunReflecting();
        }
        else if (_activityNumber == 2)
        {
            ListingActivity s1 = new ListingActivity();
            s1.RunListing();
        }
    }
    
    public int GetRandomActivity()
    {
        Random random = new Random();
        int index = random.Next(_activityNumbers.Count);
        int _number = _activityNumbers[index];
        return _number; 
    }
}