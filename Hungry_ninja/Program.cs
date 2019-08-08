using System;
using System.Collections.Generic;

namespace lasthuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet My_buffet = new Buffet();
            Ninja ninja = new Ninja();
            
            // if (ninja.IsFull == true)
            // {
            //    System.Console.WriteLine("ninja is full"); 
            // }
            // else{
                // use Eat
                // Food randomfood = My_buffet.Serve();
                // condition = only eat when ninja is not full
            while (ninja.IsFull == false){
                ninja.Eat(My_buffet.Serve());
            }
            if (ninja.IsFull){
                System.Console.WriteLine("Ninja is full");
            }
                
            

            // print the name of the food in My_buffet.Menu, which is a list of Food
            // foreach (Food item in My_buffet.Menu){
            //     System.Console.WriteLine(item.Name);
            // }

            // System.Console.WriteLine(My_buffet.Menu[0].Name);
        }
    }
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet;

        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;

        }
    }
    class Buffet
    {
        public List<Food> Menu = new List<Food>{};
        //constructor构造函数

        public Buffet() 
        // 这是个Class
        {
            Menu = new List<Food>
            {
                new Food("miso_soup",100,false, false),
                new Food("sushi", 200, false, false),
                new Food("cold_noodle",300,false, false),
                new Food("poke_bowl",400, false, false),
                new Food("tempura",500, false, false),
                new Food("clam_chowder",600, false, false),
                new Food("pizza",700, false, false)
            };
        }
        

        public Food Serve()
        // 这是个method
        {
            // Buffet currentMenu = new Buffet();
            Random rand = new Random();
            int rFood = rand.Next(0,6);
            System.Console.WriteLine(Menu[rFood].Name);
            return Menu[rFood];
        }
    }
    class Ninja
    {
        private int calorieIntake;

        public int CalorieIntake{
            get {
                return calorieIntake;
            }
        }
        public bool IsFull{
            //bool must return true or false
            get
            {
                if (calorieIntake >= 1200)
                {
                    return true;
                }
                else {
                    return false;
                }
                
            }
        }
        public List<Food> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();

        }
        public void Eat(Food item)
        {   
            // if (IsFull)
            // {
            // System.Console.WriteLine("it is full");}
            // else 
            // { 
                // Buffet currentBuffet = new Buffet();
                
                // Food dish = currentBuffet.Serve();
                // FoodHistory.Add(dish);
                calorieIntake += item.Calories;
                
            
        }
            
    }
}
