namespace LoreGame.DialogueSystem.Answers;

public class PvPAnswer : IAnswer
{
    public PvPAnswer(string answer, Dialogue nextDialogue)
    {
        Answer = answer;
        NextDialogue = nextDialogue;
    }

    public string Answer { get; set; }
    public Dialogue NextDialogue { get; set; }
    
    public void MakeAnswer()
    {
        throw new NotImplementedException();
    }
}