using System;
using System.Text;

namespace Console
{
    public class Program
    {
        private const string CharactersU = "QWERTYUOPASDFGHJKLZXCVBNM";
        private const string CharactersL = "qwertyuiopasdfghjklizxcvbnm";
        private const string SpecialCharacters = "!.";
        private const string Numbers = "1234567890";
        private const string AllCharacters = CharactersU + CharactersL + SpecialCharacters;
        private static Random rnd = new Random();
        static void Main()
        {
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < 1; i++)
            {
                char capitalLetters = GenerateChar(CharactersU);
                InsertAtRandomPositions(password, capitalLetters);
                
            }
            for (int i = 0; i < 4; i++)
            {
                char smallLetter = GenerateChar(CharactersL);
                InsertAtRandomPositions(password, smallLetter);
            }
            for (int i = 0; i<2; i++)
            {
                char number = GenerateChar(Numbers);
                InsertAtRandomPositions(password, number);
            }

            for (int i = 0; i<1; i++)
            {
                char special = GenerateChar(SpecialCharacters);
                InsertAtRandomPositions(password, special);
            }
          
            
            System.Console.WriteLine(password);
            System.Console.ReadLine();
        }   

        private static void InsertAtRandomPositions(StringBuilder password , char character)
        {

            int randomPosition = rnd.Next(password.Length + 1);
            randomPosition = NewMethod(password, character, randomPosition);

            password.Insert(randomPosition, character);

          
        }

        private static int NewMethod(StringBuilder password, char character, int randomPosition)
        {
            if (randomPosition == 0)
                if (character.Equals("!") || character.Equals("."))
                {
                    randomPosition = rnd.Next(password.Length + 1);
                }

            return randomPosition;
        }

        private static char GenerateChar (string avaibleChars)
        {
            int randomIndex = rnd.Next(avaibleChars.Length);
            char randomChar = avaibleChars[randomIndex];
            return randomChar;
        }
    }
}
