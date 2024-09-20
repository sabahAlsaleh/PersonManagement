using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonManagement.Encapsulation
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;

        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person
            {

                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight

            };

            return person;

        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public void SetFirstName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void SetLastName(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public void PrintPersonInfo(Person pers)
        {
            Console.WriteLine($" Namn: {pers.FName} {pers.LName} , Ålder: {pers.Age} , Längden: {pers.Height} , Vikt: {pers.Weight}");
        }



    }


}
