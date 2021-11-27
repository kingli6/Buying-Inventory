using System;
using System.Collections.Generic;

namespace Csharp_PlayersGuide
{
    class Program
    {
        //Excercise Page 79 Discounted Inventory //Attempt 2
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> itemInStore = new List<string> { "Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies" };
                double[] costOfItemInStore = new double[] { 10, 15, 25, 1, 20, 200, 1 };
                int itemNumber = 0;
                double discountProcent = 0.5;
                foreach (var item in itemInStore)
                {
                    Console.WriteLine($"{itemNumber} - {item}");
                    itemNumber++;
                }
                Console.Write("What is your name? ");
                string userName = Console.ReadLine().ToLower();
                bool discount = userName == "lennart" ? true : false;          //_ = userName == "lennart" ? discount = true : discount = false;           //what does _ do?

                Console.Write("What number do you want to see the price of? ");
                int userInput = int.Parse(Console.ReadLine());

                double finalCost = discount == true ? costOfItemInStore[userInput] * discountProcent : costOfItemInStore[userInput];
                //result
                Console.WriteLine($"{itemInStore[userInput]} costs {finalCost} ");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
//Excercise Page 79 Discounted Inventory //Attempt 1
/*
static void Main(string[] args)
{
    //var cc = new ConsoleCompanion();

    while (true)
    {
        Console.Clear();
        Menu();
        Console.ReadLine();
    }
}

private static void Menu()
{
    string[] itemList = new string[] { "Rope", "Torches", "Climbing Equipment", "Clean Water", "Machete", "Canoe", "Food Supplies" };
    Console.WriteLine("The following items are available:");

    for (int i = 0; i < itemList.Length; i++)
        Console.WriteLine($"{i} - {itemList[i]}");

    Console.Write("Hello, please enter your name: ");
    string name = Console.ReadLine();

    Console.Write("What number do you want to see the price of? ");
    UserChoice(name);
}
public static string userInput;
public static bool discount;
private static void UserChoice(string name)
{
    name = name.ToLower();
    if (name == "lennart")
        discount = true;
    else
        discount = false;

    userInput = Console.ReadLine();
    switch (userInput)
    {
        case "0": 
            Console.WriteLine($"Rope costs {Price(userInput)} gold.");
            break;                  
        case "1":                   
            Console.WriteLine($"Torches costs {Price(userInput)} gold.");
            break;                  
        case "2":                   
            Console.WriteLine($"Climbing Equipment costs {Price(userInput)} gold.");
            break;                  
        case "3":                   
            Console.WriteLine($"Clean water costs {Price(userInput)} gold.");
            break;                  
        case "4":                   
            Console.WriteLine($"Machete costs {Price(userInput)} gold.");
            break;                  
        case "5":                   
            Console.WriteLine($"Canoe costs {Price(userInput)} gold.");
            break;                  
        case "6":                   
            Console.WriteLine($"Food Suplies costs {Price(userInput)} gold.");
            break;
        default:
            break;
    }
}

private static double Price(string userInput)
{
    int[] cost = new[] { 10, 15, 25, 1, 20, 200, 1 };
    int userIntInput = int.Parse(userInput);
    double price;
    if (discount == true)
        price = cost[userIntInput] * 0.5;
    else
        price = cost[userIntInput];

    return price;

}
*/
