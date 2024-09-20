using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    public abstract class Animal
    {

        private int Age {get; 
            set; }
        private string Name { get; set; }
        private double Height { get; set; }

        private double Weight { get; set; }

        public Animal(int age , string name, double height, double weight)
        {
            Age = age;
            Name = name;        
            Height = height;    
            Weight = weight;
                

        }

        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Height: {Height}, Weight: {Weight}";

        }




    }


}
