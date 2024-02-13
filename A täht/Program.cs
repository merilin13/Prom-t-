namespace A_täht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.WriteLine("TÄHT A");

            Console.Write("\n");

            // Loop for iterating through rows
            for (row = 0; row <= 6; row++)
            {
                // Loop for iterating through columns
                for (column = 0; column <= 7; column++)
                {
                    // Check conditions to print '*' or ' ' for specific positions
                    if (((column == 1 || column == 5) && row != 0) ||
                        ((row == 0 || row == 3) && (column > 1 && column < 5)))
                    {
                        Console.Write("*");  // Print '*' for specific conditions
                    }
                    else
                    {
                        Console.Write(" ");  // Print ' ' for other positions
                    }
                }
                Console.Write("\n");  // Move to the next line after each row is printed
            }

            Console.Write("\n");  // Add an extra line at the end for better readability  
        }
    }
}