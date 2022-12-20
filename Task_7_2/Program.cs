using System;

namespace Task_7_2 
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите строку");
			string beginStr = Console.ReadLine();
			char[] del = new char[] { ' ', ',', '.', '?', ';', ':', '!' };
			var afterStr = String.Join(" ", beginStr.ToLower().Split(del).Distinct());

			for (int i = 0; i < afterStr.Length - 1; i++)
			{
				for (int j = 0; j < del.Length; j++)
				{
					if ((afterStr[i] == del[j] && afterStr[i] == ' ') && afterStr[i + 1] == del[j])
					{
						afterStr = afterStr.Remove(i, 1);

						if (i < 0)
						{
							i--;
						}
					}
				}
			}

			if (afterStr[0] == ' ')
			{
				afterStr = afterStr.Remove(0, 1);
			}

			Console.WriteLine("Строка после удаления\n" + afterStr);
		}
	}
}
