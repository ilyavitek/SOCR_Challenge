using System;
namespace SimpleOpticalCharacterRecognition
{
	public class Reader
	{
		public string[] Read(string name)
		{
			string[] lines = System.IO.File.ReadAllLines(name);

			System.Console.WriteLine(name + ":");
			foreach (string line in lines)
			{
				Console.WriteLine("\t" + line);
			}

			System.Console.ReadKey();

			return lines;
		}

		public string[] ChangeCodesToHorizontalRightLeft(string[] lines)
		{
			String[] newlines = new String[lines[0].Length];

			for (int j = 0; j < lines[0].Length; j++)
			{
				for (int i = 0; i < lines.Length; i++)
				{
					newlines[j] += lines[lines.Length - 1 - i][j];
				}
			}

			return lines;
		}

		public string[] ChangeCodesToHorizontalLeftRight(string[] lines)
		{

			String[] newlines = new String[lines[0].Length];

			for (int j = 0; j < lines[0].Length; j++)
			{
				for (int i = 0; i < lines.Length; i++)
				{
					newlines[j] += lines[i][j];
				}
			}

			return lines;
		}
	}
}
