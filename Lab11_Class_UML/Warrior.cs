using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Class_UML
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior() { }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            WeaponType = _weaponType;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
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

        //public override void Play(string name, int strength, int intelligence)
        //{
        //    base.Play(name, strength, intelligence);
        //    Console.WriteLine($"Weapon Type: {WeaponType}");
        //}
    }
}
