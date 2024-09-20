using System;
using System.Xml.Linq;
using PersonManagement.Encapsulation;
using PersonManagement.inheritance;
using PersonManagement.Polymorfism;

namespace PersonManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Skapa en instans av Person klass
                Person person = new Person();
                PersonHandler personHandler = new PersonHandler();

                //  Person newPerson = personHandler.CreatePerson(25, "Erik", "Karlsson", 170.5, 75.3);

                //Console.WriteLine($"Person skapad: {newPerson.FName} {newPerson.LName}, Ålder: {newPerson.Age},
                // Längd: {newPerson.Height}, Vikt: {newPerson.Weight}");
                Console.WriteLine(" *** Polymorfism *** ");
                Person p1 = personHandler.CreatePerson(30, "Anna", "Andersson", 170.2, 65.5);
                Person p2 = personHandler.CreatePerson(25, "Erik", "Karlsson", 180.4, 80);
                Person p3 = personHandler.CreatePerson(15, "alma", "kala", 165, 40);

                 // Skriv ut info om personer
                personHandler.PrintPersonInfo(p1);
                personHandler.PrintPersonInfo(p2);
                personHandler.PrintPersonInfo(p3);

                //personHandler.SetAge(p1, -1);
                personHandler.SetHeight(p1, 171.5);

                // Skriv ut uppdaterad information om person 1
                Console.WriteLine("\n  Uppdaterad information om person1:");
                personHandler.PrintPersonInfo(p1);

                Console.WriteLine("\n User Error Messages ");
                //  Skapa en lista med UserError objekt
                List<UserError> userErrors = new List<UserError>
                 {
                    new NumericInputError(),
                    new TextInputError(),
                    new FileNotFoundError(),
                    new PermissionDeniedError(),
                    new InvalidLoginError()
                };

                  // foreach för att loopa genom alla UserError objekt och skriva ut UEMessage()
                foreach (UserError error in userErrors)
                {
                    Console.WriteLine( error.UEMessage());
                }

                Console.WriteLine("\n *** Arv **** ");
                Console.WriteLine("\n *** Animals **** ");

                /// Arv
                List<Animal> animals = new List<Animal>
                {
                    new Horse(5, "Thunder", 500, 55.5, 60), 
                    new Dog(3, "Buddy", 50, 30, "Golden Retriever"), 
                    new Hedgehog(2, "Spikey", 0.2, 1, 1000), 
                    new Worm(1, "Slither", 0.01, 0.1, false), 
                    new Pelican(4, "Flappy", 1, 10, 2.5, 0.5),
                    new Wolf(6, "Alpha", 100, 60, "Alpha Wolf"),
                    new Wolfman(30, "Half-Wolf", 180, 70, "Lone Wolf") 
                };

            

                // Wolfman specific
                Wolfman wolfman = new Wolfman(30, "Half-Wolf", 180, 70, "Lone Wolf");
                wolfman.Talk();

                // F 13: Om alla fåglar behöver ett nytt attribut, lägger vi det i Bird klass eftersom den är basen för alla fåglar.
                // F 14: Om alla djur behöver det nya attributet, lägger vi det i Animal klass för alla djur ärver från den abstrakta klassen.



                Console.WriteLine(" ****  Mer polymorfism\n *****");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.Stats()); 
                
                    // F6
                    animal.DoSound();
                    Console.WriteLine();

                    // F7 : Kolla om djuret är en IPerson och anropa Talk() om så är fallet
                    if (animal is IPerson iPerson)
                    {
                        iPerson.Talk();
                    }
                }

                // Skapa en lista för hundar
                List<Dog> dogs = new List<Dog>();
                // Exempel på att lägga till en hund:
                dogs.Add(new Dog(3, "Buddy", 50, 30, "Golden Retriever"));

                // dogs.Add(new Horse(5, "Thunder", 500, 55.5, 60)); // Detta fungerar inte eftersom en Horse inte är en Dog

                // F9
                //eftersom ett objekt som läggs till i en lista vara av samma typ som listan. Listan definierad för att endast innehålla objekt av typen Dog,
                // och därför kan du inte lägga till ett objekt av typen Horse.


                // F 10
                //För att lagra alla klasser tillsammans måste listan vara av typen Animal,
                //eftersom alla subklasser ärver från Animal och därmed kan lagras i en Animal-lista

                // F13

                //  Alla djur i listan animals behandlas som Animal-objekt i loopen.
                // mha polymorfism,  anropas den version av Stats() som tillhör objektets verkliga typ (Horse, Dog ... och andra) 
                //Därför får du korrekt utdata för varje specifikt djur, där alla deras unika attribut skrivs ut enligt deras respektive Stats() implementation.



                foreach (var animal in animals)
                {


                 //   animals.FetchBall();
                    // Kontrollera om djuret är en hund
                    if (animal is Dog dog)
                    {
                        Console.WriteLine(dog.Stats());
                        Console.WriteLine(dog.FetchBall());

                    }

                }


                // F16
                // Nej ,eftersom listan är av typen Animal och metoden FetchBall() är specifik för klassen Dog.



            }
            catch (ArgumentException ex)
            {
                 //  Fångar undantaget och visar meddelandet
                Console.WriteLine($"Fel: {ex.Message}");
            }


        }
    }
}
