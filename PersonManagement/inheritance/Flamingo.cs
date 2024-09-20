using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.inheritance
{
    public class Flamingo:Bird
    {
        public Flamingo(int age, string name, double height, double weight, double wingSpan , string col) 
            : base(age, name, height, weight, wingSpan)
        {
            
        }

        public string Color { get; set; }

        
    }
}
