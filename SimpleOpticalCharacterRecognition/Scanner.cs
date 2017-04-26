using System;
using System.Collections.Generic;
namespace SimpleOpticalCharacterRecognition
{
	public class Scanner
	{

		public List<int> CountSeriesInStrings(string[] s)
		{
			List<int> series = new List<int>();
			int prevSeries = 0;
			int currentSeries = 0;

			for (int i = 0; i < s.Length; i++)
			{
				currentSeries = CountSeriesInString(s[i]);
				if (currentSeries != prevSeries && currentSeries != 0)
				{
					series.Add(currentSeries);
				}
				prevSeries = currentSeries;
			}

			return series;
		}

		int CountSeriesInString(string s)
		{
			char[] chars = new char[s.Length];

			int series = (s[0] == '*' ? 1 : 0);
			char prevChar = s[0];
			bool newSeries = true;

			for (int i = 1; i < chars.Length; i++)
			{
				if (!prevChar.Equals(s[i])) {
					if (newSeries)
					{
						series++;
					}
					newSeries = !newSeries;
				}
				prevChar = s[i];
			}

			return series;
		}
	}
}
