//Mina Stanton
//Program description: Implement polymorphism. 

using System;

namespace Lab11_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[5];
            gameCharacters[0] = new Warrior("Zelda", 25, 20, "Axe");
            gameCharacters[1] = new Warrior("Jon Snow", 50, 100, "Long Claw");
            gameCharacters[2] = new Wizard("Gandolf the Grey", 200, 150, 500, 2000);
            gameCharacters[3] = new Wizard("Gandolf the white", 500, 1000, 2000, 10000);
            gameCharacters[4] = new Wizard("Harry Potter", 500, 90, 300, 10);

           for(int i = 0; i < gameCharacters.Length; i++)
            {
                gameCharacters[i].Play();
                Console.WriteLine();
            }


        }
    }
}
