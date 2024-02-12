using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a real number
        Console.Write("Enter a real number: ");
        double x = double.Parse(Console.ReadLine());

        // Define the intervals
        double interval1a = 2;
        double interval1b = 3;
        double interval2a = 0;
        double interval2b = 1;
        double interval3a = -10;
        double interval3b = -2;

        // Test membership using only < and ==
        bool set1 = (x >= interval1a) && (x < interval1b);
        bool set2 = (x > interval2a) && (x <= interval2b);
        bool set3 = (x >= interval3a) && (x <= interval3b);

        // Display the result based on logical operators
        if (((set1 || set2) || (set3)))
        {
            Console.WriteLine("x belongs to I");
        }
        else
        {
            Console.WriteLine("x does not belong to I");
        }
    }
}
