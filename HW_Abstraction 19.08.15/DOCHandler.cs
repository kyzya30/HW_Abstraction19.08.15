using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Abstraction_19._08._15
{
    internal class DOCHandler : AbstractHandler
    {
        private string _fileName;
        public DOCHandler(string fileName)
        {
            this._fileName = fileName;
        }
        public override void Open() { Console.WriteLine("{0} DOC документ открыт", _fileName); }
        public override void Create() { Console.WriteLine("DOC документ создан"); }
        public override void Chenge() { Console.WriteLine("DOC документ был изменен"); }
        public override void Save() { Console.WriteLine("DOC документ сохранен"); }
    }
}
