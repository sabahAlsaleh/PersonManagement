using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    public class Horse: Animal
    {
        public double Speed { get; set; }

        public Horse(int age, string name, double height, double weight, double speed) : base(age, name, height, weight)
        {
            Speed = speed;

        }

        public override void DoSound()
        {
            Console.WriteLine("The horse neighs!");
        }

        public override string Stats()
        {
            return base.Stats() + $", Speed: {Speed}";
        }
    }
}
