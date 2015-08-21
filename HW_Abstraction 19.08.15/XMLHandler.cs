using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Abstraction_19._08._15
{
    internal class XMLHandler : AbstractHandler
    {
        private string _fileName;
        public XMLHandler(string fileName)
        {
            this._fileName = fileName;
        }
        public override void Open() { Console.WriteLine("{0} XML документ открыт", _fileName); }
        public override void Create() { Console.WriteLine("XML документ создан"); }
        public override void Chenge() { Console.WriteLine("XML документ был изменен"); }
        public override void Save() { Console.WriteLine("XML документ сохранен"); }
    }
}
