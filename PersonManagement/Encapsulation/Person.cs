using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonManagement.Encapsulation
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;


        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder måste vara större än 0.");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Förnamn är obligatoriskt.");
                }
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("Förnamn måste vara mellan 2 och 10 tecken.");
                }
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Efternamn är obligatoriskt.");
                }
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Efternamn måste vara mellan 3 och 15 tecken.");
                }
                lName = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Längd måste vara större än 100 cm");
                }

                height = value;

            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Vikten måste vara större än 4 kg");
                }
                weight = value;
            }
        }


    }
}
