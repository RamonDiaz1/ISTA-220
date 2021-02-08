using System;

namespace FarmAnimalsEX4
{

    class FarmAnimal
    {
    
        public void Speak(string Name, string Animal, string Noise)
        {
            Console.WriteLine($"Hello, my name is {Name} I am a {Animal} and I say {Noise}");
        }
        public void Eat( string Food, string Consumption)
        {
            Console.WriteLine($"my favorite food is {Food} and I eat it {Consumption} times a day");
        }

    }
    class Horse 
    {
        public void Speak(string Name, string Animal, string Noise)
        {
            Console.WriteLine($"Hello, my name is {Name} I am a {Animal} and I say {Noise}");
        }
        public void Eat(string Food, string Consumption)

        {
            Console.WriteLine($"my favorite food is {Food} and I eat it {Consumption} times a day");
        }
              
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Introducing the Chickens");

            FarmAnimal chicken = new FarmAnimal();
            chicken.Speak("Fivio", "rooster", "cluck");
            chicken.Eat("corn", "8");

            FarmAnimal chicken2 = new FarmAnimal();
            chicken2.Speak("Patita", "chicken", "cluck");
            chicken2.Eat($"wheat", "6");

            FarmAnimal chicken3 = new FarmAnimal();
            chicken3.Speak("Chicken Little", "chick", "cluck");
            chicken3.Eat("seeds", "4");

            FarmAnimal chicken4 = new FarmAnimal();
            chicken3.Speak("Buck Cluck", "chicken", "cluck");
            chicken3.Eat("worms", "10");
            Console.ReadKey();

            Console.WriteLine(" Introducing the Goats");

            FarmAnimal goat = new FarmAnimal();
            goat.Speak("YE", "goat", "Meeeh");
            goat.Eat("grass", "14");

            FarmAnimal goat2 = new FarmAnimal();
            goat2.Speak("Mike Tyson", "goat", "Meeeh");
            goat2.Eat("hay", "10");

            FarmAnimal goat3 = new FarmAnimal();
            goat3.Speak("Kobe", "goat", "Meeeh");
            goat3.Eat("carrots", "4");

            FarmAnimal goat4 = new FarmAnimal();
            goat4.Speak("Lebron", "goat", "Meeeh");
            goat4.Eat("grass", "14");
            Console.ReadKey();

            Console.WriteLine(" Introducing the cows");

            FarmAnimal cow = new FarmAnimal();
            goat.Speak("Betsy", "cow", "Mooo");
            goat.Eat("grass", "25");

            FarmAnimal cow2 = new FarmAnimal();
            cow2.Speak("Big Gus", "bull", "Mooo");
            cow2.Eat("apples", "10");

            FarmAnimal cow3 = new FarmAnimal();
            cow3.Speak("Daisy", "cow", "Mooo");
            cow3.Eat("grain", "16");

            FarmAnimal cow4 = new FarmAnimal();
            cow4.Speak("Angus", "bull", "Mooo");
            cow4.Eat("grass", "13");
            Console.ReadKey();

            Console.WriteLine(" Introducing Mr. Ed the horse");

            Horse horse = new Horse();
            horse.Speak("Mr. Ed", "horse", "neigh!");
            horse.Eat("hay", "6");
            Console.ReadKey();

        }
    }
}  
