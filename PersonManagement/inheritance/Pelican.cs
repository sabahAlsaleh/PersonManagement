using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    internal class Pelican : Bird
    {
        public Pelican(int age, string name, double height, double weight, double wingSpan, double beakLength)
            : base(age, name, height, weight, wingSpan)
        {
            BeakLength = beakLength;
        }

        public double BeakLength { get; set; }



    }
}
