using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    public class Hedgehog:Animal
    {
      
        public int NrOfSpikes { get; set; }
        public Hedgehog(int age, string name, double height, double weight, int nrOfSpikes) : base(age, name, height, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("The hedgehog snuffles!");
        }
        public override string Stats()
        {
            return base.Stats() + $", NrofSpikes: {NrOfSpikes}";
        }


    }
}
