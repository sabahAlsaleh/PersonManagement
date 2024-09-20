using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    internal class Swan:Bird
    {
        public Swan(int age, string name, double height, double weight, double wingSpan, string neckLength) : base(age, name, height, weight, wingSpan)
        {
            NeckLength = neckLength;
        }

        public string NeckLength { get; set; }


    }
}
