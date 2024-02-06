using System.Collections;
using LoreGame.DialogueSystem;
using LoreGame.DialogueSystem.Answers;

namespace LoreGame;

public class Game
{

    private List<Dialogue> Dialogues;

    public Game()
    {
        Dialogues = new List<Dialogue>()
        {
            new Dialogue(
                "Бабушка", 
                "Сколько печенок ты хочешь? \ud83c\udf6a"),
            new Dialogue(
                "Бабушка", 
                "Этого мало! Смотри, какой ты дрыщ! Возьмешь больше?"),
            new Dialogue(
                "Бабушка", 
                "Молодец! Я рада твоим выбором! Покорми собаку \u2665"),
            new Dialogue(
                "Бабушка", 
                "Ну хоть что-то! Иди покорми собаку"),
            
            
            
            new Dialogue(
                "Собака", 
                "Гав-гав! Покорми меня"),
            new Dialogue(
            "Собака", 
            "Теперь мы друзья! Давай поиграем")
        };
        
        
        Dialogues[0].Answers = new List<IAnswer>()
        {
            new NextDialogueAnswer("Одну печенку", Dialogues[1]),
            new NextDialogueAnswer("Две печеньки", Dialogues[3]),
            new NextDialogueAnswer("Три печеньки", Dialogues[2])
        };
        Dialogues[1].Answers = new List<IAnswer>()
        {
            new NextDialogueAnswer("Две печеньки", Dialogues[3]),
            new NextDialogueAnswer("Три печеньки", Dialogues[2]),
            new EndAnswer("Нет", "Вы отказались брать больше печенок, поэтому бабушка заставила вас их съесть силой. Вы погибли..."),
        };
        
        Dialogues[2].Answers = new List<IAnswer>()
        {
            new NextDialogueAnswer("[Отправиться к собаке]", Dialogues[4]),
            new EndAnswer("Нет", "Вас выгнали из дома. Плохая концовка"),
        };
        
        
        
        Dialogues[4].Answers = new List<IAnswer>()
        {
            new EndAnswer("Нет", "Вы отказались кормить собаку и она вас загрызла..."),
            new NextDialogueAnswer("Держи", Dialogues[5])
        };
        
        Dialogues[5].Answers = new List<IAnswer>()
        {
            new EndAnswer("Давай", "Вы хорошо провели время с собакой! Хорошая концовка"),
            new EndAnswer("Нет", "Собака обиделась на вас и вы расстались. Плохая концовка")
        };


    }

    public void Run()
    {
        Dialogues[0].Call();
    }

}