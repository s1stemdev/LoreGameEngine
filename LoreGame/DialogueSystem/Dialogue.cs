namespace LoreGame.DialogueSystem;

public class Dialogue
{
    public Dialogue(string character, string quest)
    {
        Character = character;
        Quest = quest;
    }
    
    public string Character { get; set; }
    public string Quest { get; set; }
    public List<IAnswer> Answers { get; set; }


    public void Call()
    {
        WriteQuest();
        WriteAnswerVariants();
        
        GetAnswer(out int ans);
        Answers[ans].MakeAnswer();
        
    }

    private void GetAnswer(out int ans)
    {
        Console.Write("> ");
        string raw = Console.ReadLine();

        try
        {
            ans = int.Parse(raw);
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Вы должны писать только числа");
            
            GetAnswer(out ans);
            throw;
        }
    }

    private void WriteQuest()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(Character + ": ");
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(Quest);
    }

    private void WriteAnswerVariants()
    {
        for (int i = 0; i < Answers.Count; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{i}: ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Answers[i].Answer);
        }
    }
    
    
}