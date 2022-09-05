using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_3_Task4
{
    internal class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа в версии О");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа в версии О");
        }
    }
}
