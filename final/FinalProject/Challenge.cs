using System;

//child of component class

public class Challenge
{
    //attributes
    private int _amount;
    private int _turn = 0;
    private List<string> titles = new List<string>
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
    public Challenge(string name, string description, int amount) //: base(name, description)
    {
        _amount = amount;
    }

    //methods
    /*
    public override string Display()
    {
        //change output
        return " ";
    }
    public int GetTurns()
    {
        //fix this output
        return 0;
    }
    public void SetTurns(int turn)
    {
        _turn = turn;
    }*/

}