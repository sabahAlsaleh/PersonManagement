using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    internal class Worm: Animal

    {
        public bool IsPoisonous { get; set; } // Unik egenskap
        public Worm(int age, string name, double height, double weight ,bool isPoisonous):base(age, name, height, weight) 
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("The worm is silent.");
        }

        public override string Stats()
        {
            return base.Stats() + $", IsPoisonous ? : {IsPoisonous}";
        }

    }




}
