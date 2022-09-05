using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15_4_Task5
{
    internal abstract class AbstractDocument
    {
        string content;

        public string Content
        {
            get
            {
                if (content != null)
                    return content;
                else
                    return "Контент отсутствует.";
            }
            set
            {
                content = value;
            }
        }
        public abstract void Show();
    }
}
