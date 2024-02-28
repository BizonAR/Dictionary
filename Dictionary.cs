using System;
using System.Collections.Generic;

namespace Dictionary
{
	internal class Dictionary
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> explanatoryDictionary = new Dictionary<string, string>();

			FillDictionary(explanatoryDictionary);

			Console.Write("Введите любое слово, чтобы узнать его значение: ");
			string userInput = Console.ReadLine();

			if (explanatoryDictionary.ContainsKey(userInput.ToLower()))
				Console.WriteLine($"{userInput} - {explanatoryDictionary[userInput]}");
			else
				Console.WriteLine("Такое слово не найдено.");
		}

		static void FillDictionary(Dictionary<string, string> dictionary)
		{
			dictionary.Add("аз", "выражает досаду, горечь, а также удивление, злорадство и другие подобные чувства.");
			dictionary.Add("аббат", "1. настоятель мужского католического монастыря. 2. католический священнослужитель.");
			dictionary.Add("абберация", "отклонение от чего-н., а также искажениечего-н.");
			dictionary.Add("бароко", "1. нескл., ср. вычурный и пышный стиль в искусстве 17-18 вв. " +
	"				2. неизм. Имеющий такой стиль, выполненный в таком стиле. Архитектура");
			dictionary.Add("бездождье", "отсутствие дождей, засуха.");
			dictionary.Add("ба", "Выражает удивление.");
		}
	}
}
