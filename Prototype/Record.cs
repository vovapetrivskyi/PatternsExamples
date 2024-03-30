using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Record : IPrototype
    {
        public DateTime CreationTime { get; set; }

        public string Message { get; set; }

        public int Number { get; set; }

        public Record()
        {
            CreationTime = DateTime.Now;
            Message = "";
        }

        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Message = {this.Message}, Number = {this.Number}, created at {this.CreationTime}");
        }
    }
}
