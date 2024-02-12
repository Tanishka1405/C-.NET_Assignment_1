using System;

class RoseBlanches
{
    static void Main()
    {
        // Input the amount of money received
        Console.Write("How much money did you receive ($) ?");
        double totalAmount = double.Parse(Console.ReadLine());

        // Calculate three-fourths of the total amount for books and supplies
        double books_And_Supplies = 0.75 * totalAmount;

        // Calculate the remaining one-fourth of the total amount
        double remaining_Amount = 0.25 * totalAmount;
        double three_fold = remaining_Amount / 3;

        // Calculate the cost of each item
        double coffee_Cost = 2;
        double flash_Computer_Cost = 4;
        double subway_Ticket_Cost = 3;

        // Calculate the number of coffees, Flash Computers, and subway tickets that can be bought
        int num_Coffees = (int)(three_fold / coffee_Cost);
        int num_Flash_Computers = (int)(three_fold / flash_Computer_Cost);
        int num_Subway_Tickets = (int)(three_fold / subway_Ticket_Cost);

        // Calculate the amount spent on each item
        double spent_On_Coffees = num_Coffees * coffee_Cost;
        double spent_On_Flash_Computers = num_Flash_Computers * flash_Computer_Cost;
        double spent_On_Subway_Tickets = num_Subway_Tickets * subway_Ticket_Cost;

        // Calculate the remaining amount for white flowers
        double money_Left_For_WhiteFlowers = remaining_Amount - spent_On_Coffees - spent_On_Flash_Computers - spent_On_Subway_Tickets;


        Console.WriteLine("\nBook and Supplies : $" + books_And_Supplies);
        Console.WriteLine("You can then buy : " + num_Coffees + " coffees");

        Console.WriteLine("\n" + num_Flash_Computers + " Flash Computer Numbers");
        Console.WriteLine(num_Subway_Tickets + " subway Tickets");
        Console.WriteLine("and you will have " + money_Left_For_WhiteFlowers + " dollars for the white roses.");

    }
}
