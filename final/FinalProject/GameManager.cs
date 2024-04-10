using System;
using System.Data;

/*So the game manager is in charge of 
CREATING the challenges and potions , initializing the inventory
UPDATING the different components
comparing the amounts/targets and VALIDATING for the main to continue to the next menu*/
public class GameManager
{
    //attributes
    private int _potionIndex;
    private int _index;
    private int _money;
    private int _turn;
    List<Challenge> _challenges = new List<Challenge>();
    List<Potion> _potions = new List<Potion>();
    
    private List<string> _names = new List<string>
    {
        "Cure the village!",
        "Stop a monster!",
        "Cater a wedding!"
    };
    private List<string> _descriptions = new List<string>
    {
        "Ye gads, a strange illness is spreading through the city! The villagers need a cure.",
        "Help the heroes create a poison that will help them defeat the beast nesting near our home! We need bottles of poison to beat it.",
        "The lord of the village knows you make the best fizzy punch. He has requested you cater his wedding."
    };

    //constructors na but intialize ??
    public GameManager()
    {   
        _potionIndex = 0;
        _money = 25;
        _turn = 5;
        //intialize challenges
        
        Random rand = new Random();
        int _challengeIndex = rand.Next(3); 
        //add to respective list
        Challenge one = new Challenge(_names[_challengeIndex], _descriptions[_challengeIndex], _challengeIndex);
        Challenge two = new Challenge(_names[_challengeIndex], _descriptions[_challengeIndex], _challengeIndex);
        Challenge three = new Challenge(_names[_challengeIndex], _descriptions[_challengeIndex], _challengeIndex);
        _challenges.Add(one);
        _challenges.Add(two);
        _challenges.Add(three);
        //Initialize set potions
        Potion cure = new Potion("Cure", "Cures any disease but it is difficult to make.");
        Potion poison = new Potion("Poison", "Can coat a weapon to deal more damage, in theory.");
        Potion fizzy = new Potion("Fizzy", "A yummy drink, your specialty!");
        _potions.Add(cure);
        _potions.Add(poison);
        _potions.Add(fizzy);
    }


    //methods
    public bool isComplete()
    {
        bool complete = false;
        if (_challenges[_index].GetAmount == _potions[_index].GetAmount)
        {
            complete = true;
        }
        return complete;
    }
    public void BrewBridge(int potionIndex)
    {
        _potions[_potionIndex].Brew();
        Console.WriteLine("\nBrewing");
        for(int i = 3; i <0; i--)
        {
        Thread.Sleep(1000);
        Console.Write(".");
        }
    }
    public void LessonBridge(int potionIndex)
    {
        _potions[_potionIndex].Brew();
        Console.WriteLine("\nLearning");
        for(int i = 3; i <0; i--)
        {
        Thread.Sleep(1000);
        Console.Write(".");
        }
    }

}