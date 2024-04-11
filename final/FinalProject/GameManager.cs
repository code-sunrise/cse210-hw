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
    private int _index = 0;
    private int _money;
    private int _turn = 1;
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
        _turn = 0;
        //intialize challenges

        Random rand = new Random();
        int _challengeIndex1 = rand.Next(3);
        //add to respective list
        Challenge one = new Challenge(_names[_challengeIndex1], _descriptions[_challengeIndex1], _challengeIndex1);
        int _challengeIndex2 = rand.Next(3);
        Challenge two = new Challenge(_names[_challengeIndex2], _descriptions[_challengeIndex2], _challengeIndex2);
        int _challengeIndex3 = rand.Next(3);
        Challenge three = new Challenge(_names[_challengeIndex3], _descriptions[_challengeIndex3], _challengeIndex3);
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
    public void IsComplete()
    {
        int target = _challenges[_index].GetAmount();
        int current = _potions[_index].GetAmount();
        if (target <= current)
        {
            _challenges[_index].SetComplete();
            current -= target;
            _potions[_index].SetAmount(current);
            Console.WriteLine("Challenge completed!");
            _index += 1;
            _turn = 0;
        }
    }
    public bool isAllComplete()
    {
        bool completed = false;
        foreach (Challenge challenge in _challenges)
        {
            if (challenge.GetComplete())
            {
                completed = true;
            }
        }
        return completed;
    }
    public bool isOver()
    {
        bool over = false;
        if (_turn >= _challenges[_index].GetTurns())
        {
            over = true;
        }
        return over;
    }
    public void BrewBridge(int potionIndex)
    {
        _turn += 1;
        _potions[_potionIndex].Brew();
        Console.WriteLine("\nBrewing...");
        Thread.Sleep(2000);

    }
    public void LessonBridge(int potionIndex)
    {
        if (_money >= 25)
        {
            _turn += 1;
            _money -= 25;
            _potions[_potionIndex].Lesson();
            Console.WriteLine("\nLearning");
            Console.WriteLine("...");
            Thread.Sleep(1000);
        }
        else
        {
            Console.WriteLine("You don't have enough money for that, try something else.");
            Thread.Sleep(1500);
        }
    }
    public void SellBridge(int potionIndex)
    {

        _turn += 1;
        int income = _potions[_potionIndex].Sell();
        _money += income;
        Console.WriteLine("\nSelling...");
        Thread.Sleep(2000);
    }
    public void Inventory()
    {
        Thread.Sleep(1000);
        Console.WriteLine($"{_challenges[_index].Display()}");
        Thread.Sleep(1000);
        Console.WriteLine($"You have taken {_turn} turn(s).");
        Thread.Sleep(1000);
        Console.WriteLine($"\nCurrent Gold: {_money}");
        Thread.Sleep(2000);
        Console.WriteLine("\nPotions:");
        Thread.Sleep(1500);
        Console.WriteLine($"{_potions[0].Display()}\n");
        Thread.Sleep(2500);
        Console.WriteLine($"{_potions[1].Display()}\n");
        Thread.Sleep(2500);
        Console.WriteLine($"{_potions[2].Display()}\n");
        Thread.Sleep(2500);
    }

}