using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(int age, string name, double height, double weigh, string packLeader) : base(age, name, height, weigh, packLeader)
        {

        }

        public void Talk()
        {
            Console.WriteLine("The wolfman growls and says: 'I am a wolfman!'");
        }

        // dosound? 
        public override void DoSound()
        {
            Console.WriteLine("Wolfman howls like a wolf!");
        }

    }
}
