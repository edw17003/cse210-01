/***********************
*   W01 Tic Tac Toe
*   Jake Edwards
***********************/

// Initialize Variables
List<string> grid = new List<string>{"1", "2", "3", "4", "5", "6", "7", "8", "9"};
char player1 = 'x';
char player2 = 'o';
int selection = 0;
string winner = "v";

for (int i = 0; i < 9; i++)
{
    // Display current board
    Console.WriteLine(grid[0] + "|" + grid[1] + "|" + grid[2]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(grid[3] + "|" + grid[4] + "|" + grid[5]);
    Console.WriteLine("-+-+-");
    Console.WriteLine(grid[6] + "|" + grid[7] + "|" + grid[8]);

    // Prompt for number (make mark)
    if (i == 0 || i == 2 || i == 4 || i == 6 || i == 8)
    {
        Console.Write("\n" + player1 + "'s turn to choose a square (1-9): ");
        selection = Convert.ToInt32(Console.ReadLine());
        selection--;
        Console.WriteLine();
        grid[selection] = "X";
    }
    else
    {
       Console.Write("\n" + player2 + "'s turn to choose a square (1-9): ");
       selection = Convert.ToInt32(Console.ReadLine());
       selection--;
       Console.WriteLine();
       grid[selection] = "O";
    }

    // Check for winners
    if (grid[0] == grid[1] && grid[1] == grid[2])
    {
        winner = grid[0];
        i = 10;
    }
    else if (grid[3] == grid[4] && grid[4] == grid[5])
    {
        winner = grid[3];
        i = 10;
    }
    else if (grid[6] == grid[7] && grid[7] == grid[8])
    {
        winner = grid[6];
        i = 10;
    }
    // Vertical
    else if (grid[0] == grid[3] && grid[3] == grid[6])
    {
        winner = grid[0];
        i = 10;
    }
    else if (grid[1] == grid[4] && grid[4] == grid[7])
    {
        winner = grid[1];
        i = 10;
    }
    else if (grid[2] == grid[5] && grid[5] == grid[8])
    {
        winner = grid[2];
        i = 10;
    }
    // Diagonal
    else if (grid[0] == grid[4] && grid[4] == grid[8])
    {
        winner = grid[0];
        i = 10;
    }
    else if (grid[2] == grid[4] && grid[4] == grid[6])
    {
        winner = grid[2];
        i = 10;
    }
}

Console.WriteLine("Player " + winner + " wins!\n");