using System;
using System.ComponentModel;

//child of component class

public class Challenge
{
    //attributes
    string _name;
    string _description;
    private int _amount;
    private int _turn;
    private List<string> names = new List<string>
    {
        "Stop a monster!",
        "Cater a wedding!",
        "Cure the village!"
    };
    private List<string> descriptions = new List<string>
    {
        "Help the heroes create a poison that will help them defeat the beast nesting near our home! We need {amount} bottles of poison to beat it.",
        "The lord of the village knows you make the best fizzy punch. He has requested you provide {amount}} for his wedding.",
        "Ye gads, a strange illness is spreading through the city! {amount} villagers need a cure."
    };

    //constructors
    public Challenge()
    {
        _turn = 0;
        _amount = 3;
        _name = "weebo monster";
        _description = "A lame monster for testing potions on";
        /*pick a random number that corresponds with the .length of the names list
        and then use that to get the description as well*/
    }

    //methods
    
    /*public override string Display()
    {
        //change output
        return " ";
    }*/
    public int GetTurns()
    {
        //fix this output
        return 0;
    }
    public void SetTurns(int turn)
    {
        _turn = turn;
    }
}