using System;
using System.Collections.Generic;
namespace SimpleOpticalCharacterRecognition
{
	public class CodeManager
	{
		Dictionary<string, string> vCodes =
			new Dictionary<string, string>();

		Dictionary<string, string> hLeftRightCodes =
			new Dictionary<string, string>();

		Dictionary<string, string> hRightLeftCodes =
			new Dictionary<string, string>();

		public CodeManager()
		{
			vCodes.Add("1212","A");
			vCodes.Add("12121", "B");
			vCodes.Add("1", "C");
		}

		public void Check(List<int> series)
		{
			string code = CreateStringCodeFromList(series);
			string resultLetter;

			Console.WriteLine("Code: " + code);

			if (vCodes.TryGetValue(code, out resultLetter))
			{
				Console.WriteLine("This is letter: " + resultLetter);
			}
			else
			{
				Console.WriteLine("Recognition error");
			}
		}

		string CreateStringCodeFromList(List<int> series)
		{
			string code = string.Empty;

			foreach (int s in series)
			{
				code += s.ToString();
			}

			return code;
		}
	}
}
