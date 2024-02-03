using Mission4TicTacToe;

public class Driver
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Tic-Tac-Toe Game!");

        TTTtools gameBoard = new TTTtools();
        char currentPlayer = 'X';
         
        while (true)
        {
            // Print the current state of the board
            gameBoard.PrintBoard();

            // Get player's move
            Console.Write($"Player {currentPlayer}, enter your move (row): ");
            int row;
            // Validate user input for row
            while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row >= 3)
            {
                gameBoard.PrintBoard();
                Console.WriteLine("Invalid input! Please enter a valid row (0, 1, or 2): ");
            }

            Console.Write($"Player {currentPlayer}, enter your move (column): ");
            int col;
            // Validate user input for column
            while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col >= 3)
            {
                gameBoard.PrintBoard();
                Console.WriteLine("Invalid input! Please enter a valid column (0, 1, or 2): ");
            }

            // Update the board with the player's move
            gameBoard.UpdateBoard(row, col, currentPlayer);

            // Check for a winner
            if (gameBoard.CheckForWinner())
            {
                // Print the final state of the board
                gameBoard.PrintBoard();

                // Announce the winner
                Console.WriteLine($"Player {currentPlayer} wins!");
                break;
            }

            // Switch to the other player
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
}

