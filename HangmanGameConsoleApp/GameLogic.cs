using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGameConsoleApp
{
	public class GameLogic
	{
		public int playerLives = 5;
		public string guessWord = "Startrek";

		public void Game()
		{
			int guessWordCount = guessWord.Length;
			char[] guessWordCharacters = new char[guessWordCount];
			char[] displayedWord = new char[guessWordCount];
			char[] result = new char[guessWordCount];

			Console.WriteLine("Welcome to Hangmen Game!");
			Console.WriteLine("Try to guess the word: ");
			Console.WriteLine("Word count is " + guessWordCount);

			for (int i = 0; i < guessWordCharacters.Length; i++)
			{
				Console.Write("_ ");
				guessWordCharacters[i] = guessWord[i];
			}
			Console.WriteLine("\n");
			while (playerLives != 0)
			{
				Console.WriteLine("\n\nAdd a letter: \n");
				char playerguessChar = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("\n");

				for (int i = 0; i < guessWordCharacters.Length; i++)
				{
					if (guessWordCharacters[i] == playerguessChar)
					{
						displayedWord[i] = playerguessChar;
						
					}
					else
					{
						displayedWord[i] = '_';
						
					}
	
				}

				for (int i = 0; i < displayedWord.Length; i++)
				{

					Console.Write(displayedWord[i]);
				}
				result = displayedWord;

				Console.WriteLine("\n");
			}
			
			if (playerLives == 0)
			{
				Console.WriteLine("You lost!\n The word is: " + guessWord);
			}
			else
			{
				Console.WriteLine("You win! :)");
			}
		}
	}
}
