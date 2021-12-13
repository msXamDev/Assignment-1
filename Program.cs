// See https://aka.ms/new-console-template for more information
using System.Drawing;

#region Print Star Pattern
//int row, column, max = 4;
//for (row = 1; row <= 5; row++)
//{
//    for (column = 1; column <= row; column++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}

//for (row = 1; row <= max; row++)
//{
//    for (column = 1; column <= row; column++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//for (row = max; row >= 1; row--)
//{
//    for (column = 1; column <= row; column++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();
#endregion

#region Find Factorial

//Console.WriteLine("Enter a number");
//int number = Convert.ToInt32(Console.ReadLine());
//int fact = 1;
//for (int i = number; i >= 1; i--)
//{
//    fact *= i;
//}
//Console.WriteLine(fact);
#endregion

#region Chess Board
int row, column;
string ChessBoard = "<table style='width:270px; height: 30px; border: solid 1px #ccc'>";
for (column = 0; column < 10; column++)
{
    ChessBoard += "<tr>";
    for (row = 0; row < 10; row++)
    {
        if ((row + column) % 2 == 0)
        {
            ChessBoard += "<td height=30px width=270px bgcolor=black></td>";
        }
        else
        {
            ChessBoard += "<td height=30px width=270px bgcolor=white></td>";
        }
    }
    ChessBoard += "</tr>";
}
ChessBoard += "</table>";
File.WriteAllText(@"D:\chessboard.html", ChessBoard);
Console.WriteLine("Chessboard File created");
Console.ReadLine();
#endregion