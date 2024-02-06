namespace LoreGame.DialogueSystem.Answers;

public class EndAnswer : IAnswer
{

    public EndAnswer(string answer)
    {
        Answer = answer;
    }
    
    public EndAnswer(string answer, string endText)
    {
        Answer = answer;
        EndText = endText;
    }

    public string Answer { get; set; }
    public string EndText { get; set; }
    
    public Dialogue NextDialogue { get; set; }
    
    public void MakeAnswer()
    {
        if (EndText != null)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(EndText);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        Console.WriteLine("Нажмите ESC для выхода");
        do {
            while (! Console.KeyAvailable) {
            }       
            
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        Environment.Exit(666);
    }
}