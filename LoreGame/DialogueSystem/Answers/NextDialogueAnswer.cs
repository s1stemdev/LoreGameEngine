namespace LoreGame.DialogueSystem.Answers;

public class NextDialogueAnswer : IAnswer
{
    public NextDialogueAnswer(string answer, Dialogue nextDialogue)
    {
        Answer = answer;
        NextDialogue = nextDialogue;
    }

    public string Answer { get; set; }
    public Dialogue NextDialogue { get; set; }
    
    public void MakeAnswer()
    {
        NextDialogue.Call();
    }
}