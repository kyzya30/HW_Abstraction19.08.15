using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Abstraction_19._08._15
{
    internal class TXTHandler : AbstractHandler
    {
        private string _fileName;
        public TXTHandler(string fileName)
        {
            this._fileName = fileName;
        }
        public override void Open() { Console.WriteLine("{0} TXT документ открыт", _fileName); }
        public override void Create() { Console.WriteLine("TXT документ создан"); }
        public override void Chenge() { Console.WriteLine("TXT документ был изменен"); }
        public override void Save() { Console.WriteLine("TXT документ сохранен"); }
    }
}
