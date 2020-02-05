using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Class_UML
{
    abstract class GameCharacter
    {
        public string Name{ get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }

            
        //methods
        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {Name} \nStrength Level: {Strength} \nIntelligence Level: {Intelligence}");

        }


    }
}
