namespace sum_of_the_right_diagonals_of_a_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking the user for the input of rows
            Console.WriteLine("Enter the amount of rows you would like: ");
            int rows = int.Parse(Console.ReadLine());
            // now telling the 2d array that number that was entered by the user
            int[,] matrix = new int[rows, rows];
            // this prints out "Enter your numbers" up to the amount of rows the user chose by saying i(Element) starts at 0 and increses until i = rows and the same thing for jut j is the secound collum
            for (int i = 0; i < rows; i++)
            {
                
                for (int j = 0; j < rows; j++)
                {
                    //if the user chooses 2 rows it will * that number to get the amount of elements
                    Console.WriteLine(" Enter your numbers ");
                    matrix[i, j] =int.Parse(Console.ReadLine());
                }

            }
            
            int sum = 0;
            for (int i = 0;i < rows; i++)
            {
                sum += matrix[i, rows-1-i];
                
            }
            // displaying the sum of those numbers 
            Console.WriteLine($"Addition of the right diagonal elements is : {sum}");
        }
    }
}
