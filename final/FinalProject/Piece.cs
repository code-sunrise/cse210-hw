using System;

//parent of other game pieces, all of them have the same basics

public class Piece
{
    //attributes
    protected string _name;
    protected string _description;
    

    //constructors
    public Piece(string name, string description)
    {
        _name = name;
        _description = description;

    }

    //methods
        public string Display()
    {
        return "test";
    }
}
