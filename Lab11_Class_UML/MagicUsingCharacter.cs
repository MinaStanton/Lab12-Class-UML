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

        //public override void Name(string name)
        //{
        //    Console.WriteLine($"Character Name: {name}");
        //}

        //public override void Strength(int strength)
        //{
        //    Console.WriteLine($"Strength: {strength}");
        //}

        //public override void Intelligence(int intelligence)
        //{
        //    Console.WriteLine($"Intelligence: {intelligence}");
        //}

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}
