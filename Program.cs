// Initialize Variables
List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
char player1 = 'x';
char player2 = 'o';
int selection = 0;

for (int i = 0; i < 9; i++)
{
    // Display current board
    Console.WriteLine(numbers[0] + "|" + numbers[1] + "|" + numbers[2]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(numbers[3] + "|" + numbers[4] + "|" + numbers[5]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(numbers[6] + "|" + numbers[7] + "|" + numbers[8]);

    // Prompt for number
    if (i == 0 || i == 2 || i == 4 || i == 6 || i == 8)
    {
        Console.Write("\n" + player1 + "'s turn to choose a square (1-9): ");
        selection = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
    }
    else
    {
       Console.Write("\n" + player2 + "'s turn to choose a square (1-9): ");
       selection = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(); 
    }
}