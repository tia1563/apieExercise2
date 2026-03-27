using System;

namespace HelloWorld
{
    class Examples
    {
        static void Main(string[] args)
        {
            // primer za Abstraction
            BooksExample.Book1 book1 = new BooksExample.Book1();
            book1.nameOfTheBook(); // ispisuje: No Longer Human
            book1.quote();         // ispisuje: Life goes on.

            BooksExample.Book2 book2 = new BooksExample.Book2();
            book2.nameOfTheBook(); // ispisuje: The Setting Sun
            book2.quote();         // ispisuje: Life goes on.


            // primer za Encapsulation
            DrinksExample.Drinks drink = new DrinksExample.Drinks();
            drink.Name = "Chamomile tea";
            drink.GetDrink();


            // primer za inheritance
            GroceriesExample.Fruits fruit = new GroceriesExample.Fruits();
            fruit.Category = "Fruit";
            fruit.FruitName = "Apple";
            fruit.Message();
            fruit.ShowFruit();

            GroceriesExample.Vegetables vegetable = new GroceriesExample.Vegetables();
            vegetable.VegetableName = "Carrot";
            vegetable.ShowVegetable();

            // primer za Polymorphism
            CarExample.Car1 car1 = new CarExample.Car1();
            CarExample.Car2 car2 = new CarExample.Car2();

            car1.NameOfTheCar();
            car2.NameOfTheCar();
        }
    }

    // Abstraction 
    public class BooksExample
    {
        public abstract class Book
        {
            // abstract metoda (nema body)
            public abstract void nameOfTheBook();

            // obicna metoda
            public void quote()
            {
                Console.WriteLine("Life goes on.");
            }
        }
        public class Book1 : Book
        {
            public override void nameOfTheBook()
            {
                Console.WriteLine("No Longer Human");
            }
        }
        public class Book2 : Book
        {
            public override void nameOfTheBook()
            {
                Console.WriteLine("The Setting Sun");
            }
        }
    }

    // Encapsulation
    public class DrinksExample
    {
        public class Drinks
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public void GetDrink()
            {
                Console.WriteLine($"The drink is {Name} tea");
            }
        }
    }

    // Inheritance
    public class GroceriesExample
    {
        public class Groceries
        {
            public string Category;
            public void Message()
            {
                Console.WriteLine("Here is a list of what to buy:");
            }
        }

        public class Fruits : Groceries
        {
            public string FruitName;
            public void ShowFruit()
            {
                Console.WriteLine($"Buy:{FruitName}");
            }
        }

        public class Vegetables : Groceries
        {
            public string VegetableName;
            public void ShowVegetable()
            {
                Console.WriteLine($"Buy:{VegetableName}");
            }
        }
    }

    public class CarExample
    {
        public class Car
        {
            // virtual- metoda moze biti promenjena u izvedenim klasama
            public virtual void NameOfTheCar()
            {
                Console.WriteLine("The name of the car is:");
            }
        }

        public class Car1 : Car
        {
            public override void NameOfTheCar()
            {
                Console.WriteLine("BMW X3");
            }
        }

        public class Car2 : Car
        {
            public override void NameOfTheCar()
            {
                Console.WriteLine("Mercedes-Benz S-Class");
            }
        }
    }
}