public class PromptGenerator
{
    public List<string> _prompt = new List<string>();

    public PromptGenerator()
    {
        _prompt.Add("What did I accomplish today that made a difference?");
        _prompt.Add("What new person did you meet today?");
        _prompt.Add("What made you feel happy today?");
        _prompt.Add("What event occured that you want remember?");
        _prompt.Add("What made you laugh today?");
    } 

    public string DisplayPrompt()
    {
        Random promtRandom = new Random();

        int index = promtRandom.Next(_prompt.Count);
        return  _prompt[index]; 
    }

}