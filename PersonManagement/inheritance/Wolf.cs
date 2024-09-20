using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    internal class Wolf: Animal
    {

        public string PackLeader { get; set; }
        public Wolf(int age, string name, double height, double weigh, string packLeader):base(age, name, height, weigh)   
        {
            PackLeader = packLeader;
        }

        public override void DoSound()
        {
            Console.WriteLine("The wolf howls!");
        }

        public override string Stats()
        {
            return base.Stats() + $", PackLeader: {PackLeader}";
        }

    }
}
