using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    public class Bird : Animal

    {
        public double WingSpan { get; set; } // Unik egenskap

        public Bird(int age, string name, double height, double weight ,double wingSpan) : base(age, name, height, weight)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("The bird chirps!");
        }

        public override string Stats()
        {
            return base.Stats() + $", WingSpan: {WingSpan}";
        }


    }
}
