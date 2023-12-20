using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var mybird = new Birds();

            mybird.TypeOfAnimal = "Bird";
            mybird.NameInType = "Bald Eagle";
            mybird.LandSeaAir = "air";
            mybird.NoOfLegs = 2;
            mybird.TypeOfFood = "Other small animals";
            mybird.ColorOfFeathers = "Brown";
            mybird.CanFly = true;
            mybird.MostKnownFor = "American national bird.";

            
            Console.WriteLine($"The animal you are looking at is a {mybird.TypeOfAnimal}. It is called a {mybird.NameInType}.");
            
            Console.WriteLine($"You can usually see them in the {mybird.LandSeaAir}.");

            Console.WriteLine($"They have {mybird.NoOfLegs} legs. Typically they are thought to be {mybird.ColorOfFeathers}");

            Console.WriteLine($"These animals usually eat {mybird.TypeOfFood} and are most know as {mybird.MostKnownFor}");

            Console.WriteLine();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var mysnake = new Reptiles()
            {
                TypeOfAnimal = "Reptile",
                NameInType = "King Cobra",
                LandSeaAir = "Land",
                NoOfLegs = 0,
                TypeOfFood = "Other small animals",
                WalksOrSlithers = "slither",
                HasVenom = true,
                MostKnownFor = "being one of the most venomous snakes in the world.",

            };

            Console.WriteLine($"The animal you are looking at is a {mysnake.TypeOfAnimal}. It is called a {mysnake.NameInType}.");

            Console.WriteLine($"You can usually see them in the {mysnake.LandSeaAir}.");

            Console.WriteLine($"They have {mysnake.NoOfLegs} legs. Typically they are thought to {mysnake.WalksOrSlithers}");

            Console.WriteLine($"These animals usually eat {mysnake.TypeOfFood} and are most know as {mysnake.MostKnownFor}");

            Console.WriteLine();
        }
    }
}
