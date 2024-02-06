namespace LoreGame.DialogueSystem;

public interface IAnswer
{
    
    string Answer { get; set; }
    Dialogue NextDialogue { get; set; }

    void MakeAnswer();

}