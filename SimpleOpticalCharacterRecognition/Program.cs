using System;
using System.Collections.Generic;

namespace SimpleOpticalCharacterRecognition
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string filePath;
			Console.WriteLine("Enter file path:");
			filePath = Console.ReadLine();

			if (System.IO.File.Exists(filePath))
			{
				Reader m_reader = new Reader();

				string[] verticalFromUpToDownLines = m_reader.Read(filePath);

				string[] horizontalFromLeftToRightLines = m_reader.ChangeCodesToHorizontalLeftRight(verticalFromUpToDownLines); //for future
				string[] horizontalFromRightToLeftLines = m_reader.ChangeCodesToHorizontalRightLeft(verticalFromUpToDownLines); // for future

				Scanner m_scaner = new Scanner();
				List<int> vSeries = m_scaner.CountSeriesInStrings(verticalFromUpToDownLines);

				CodeManager cd = new CodeManager();
				cd.Check(vSeries);
			}
			else
			{
				Console.WriteLine("There is no such file");
			}
		}
	}
}
