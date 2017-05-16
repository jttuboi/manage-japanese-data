using System;
using System.IO;
using CsvHelper;
using System.Linq;

namespace ManageJapaneseData
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var csv1000 = new CsvReader(File.OpenText(@"/Users/ryujin/Downloads/deck1000.csv"));
			var deck1000 = csv1000.GetRecords<Card1000>();

			var csvJlpt = new CsvReader(File.OpenText(@"/Users/ryujin/Downloads/deckJLPT.csv"));
			var deckJlpt = csvJlpt.GetRecords<CardJlpt>();

			Console.WriteLine(deck1000.LongCount());
			Console.WriteLine(deckJlpt.LongCount());


			//criar uma nova tabela merge
			//criar um loop q pega o primeiro, compara a coluna kana e kanji e adiciona na linha
		}
	}
}
