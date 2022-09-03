using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_1_Additional
{
    internal class Author
    {
        private string name = null;
        public string Name
        {
            set { this.name = value; }
            get { return name; }
        }
        public Author()
        {

        }
        public void Show()
        {
            Console.Write($" {name} ");
        }
    }
}
