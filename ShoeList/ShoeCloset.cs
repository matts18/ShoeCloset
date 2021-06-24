using System;
using System.Collections.Generic;

namespace ShoeList
{
    public class ShoeCloset
    {

        private readonly List<Shoe> shoes = new List<Shoe>();

        public void PrintShoes()
        {
            if(shoes.Count > 0)
            {
                Console.WriteLine("The shoe closet contains:");
                int count = 1;
                foreach(Shoe shoe in shoes)
                {
                    Console.WriteLine($"Shoe #{count++}: {shoe.Description}");
                }
            }
            else
            {
                Console.WriteLine("The shoe close is empty.");
            }
        }

        
        public void AddShoe()
        {
            Console.WriteLine("\nAdd a shoe");
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Press {i} to add a {(Style)i}");
            }
            Console.Write("Enter a style: ");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(),out int style))
            {
                Console.Write("\nEnter the color: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style)style, color);
                shoes.Add(shoe);

            }
        }

        public void RemoveShoe()
        {
            Console.WriteLine("\nEnter the number of the shoe to remove:");
            if(int.TryParse(Console.ReadKey().KeyChar.ToString(),out int shoeNumber) &&
                (shoeNumber >= 1) && (shoeNumber <= shoes.Count))
            {
                Console.WriteLine($"Removing {shoes[shoeNumber - 1].Description}");
                shoes.RemoveAt(shoeNumber - 1);
            }
        }
    }
}
