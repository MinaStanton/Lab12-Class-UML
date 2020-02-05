using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11_Class_UML
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }//adding weapon type 

        public Warrior() { }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            WeaponType = _weaponType;
        }

        public override void Play()//override Play to include Weapon type
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }
    }
}
