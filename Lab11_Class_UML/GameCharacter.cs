using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Class_UML
{
    abstract class GameCharacter
    {
        //protected string name;
        //protected int strength;
        //protected int intelligence;

        public string Name{ get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

       // public GameCharacter() { }

        //public GameCharacter(string _name, int _strength, int _intelligence)
        //{
        //    Name = _name;
        //    Strength = _strength;
        //    Intelligence = _intelligence;
        //}

            
        //methods
        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {Name} \nStrength Level: {Strength} \nIntelligence Level: {Intelligence}");

        }


    }
}
