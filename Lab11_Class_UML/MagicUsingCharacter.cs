using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Class_UML
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter() { }
        public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicalEnergy)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;

        }

        public override void Play()//override Play to include Magical energy
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
