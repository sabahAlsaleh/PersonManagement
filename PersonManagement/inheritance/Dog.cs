using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonManagement.inheritance
{
    public class Dog:Animal
    {

        public string Breed { get; set; }
        public Dog(int age, string name, double height, double weight, string breed):base(age, name, height, weight)
        {
           Breed = breed;
        }

        public override void DoSound()
        {
            Console.WriteLine("The dog barks!");
        }


        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }
        public string FetchBall()
        {
            return " the dog is fetching the ball!";
        }
    }
}
