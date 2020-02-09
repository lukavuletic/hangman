using System; 

namespace ConsoleApp1 {
	class Program {
		static void Main(string[] args) {
			string[] words = { "this", "that", "something", "nothing", "anything", "everything" };
			Random randomIdx = new Random();
			string selectedWord = words[randomIdx.Next(0, 5)];
			foreach(char letter in selectedWord)
			{
				Console.Write('*');
			}
			Console.WriteLine();
			string processedWord = "";
			for(int i = 0; i < selectedWord.Length; i++)
			{
				processedWord = String.Concat(processedWord, "*");
			}
			do
			{
				char guess = char.Parse(Console.ReadLine());
				if (selectedWord.Contains(guess))
				{
					Console.WriteLine("Nice guess");
					for (int i = 0; i < selectedWord.Length; i++)
					{
						if (selectedWord[i] == guess)
						{
							processedWord = processedWord.Remove(i, 1);
							processedWord = processedWord.Insert(i, selectedWord[i].ToString());
						}
					}
					Console.WriteLine(processedWord);
				}
				else
				{
					Console.WriteLine("Try again");
				}
			} while (processedWord.Contains('*'));
			Console.WriteLine("Congratulations");
		}
	}
}
