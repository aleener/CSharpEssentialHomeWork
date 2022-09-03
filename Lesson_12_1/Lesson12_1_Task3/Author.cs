using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Task3
{
    internal class Author
    {
		public string text;
		public void Show()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(text);
			Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
