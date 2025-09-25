using System;

namespace PKPZlab1
{
    public class BlackKing
    {
        public int X { get; }
        public int Y { get; }

        public BlackKing(int x, int y)
        {
            if (x < 1 || x > 8 || y < 1 || y > 8)
                throw new ArgumentException("Coordinates must be between 1 and 8!");

            X = x;
            Y = y;
        }

        public int[] ToArray()
        {
            return new int[] { X, Y };
        }

        public void Print()
        {
            Console.WriteLine($"Black King is at ({X}, {Y})");
        }
    }

    public static class Chess
    {
        public static int[] Input(string name)
        {
            int[] pos = new int[2];
            Console.WriteLine($"Enter coordinates of {name} (x y):");
            string[] parts = Console.ReadLine().Split();
            pos[0] = int.Parse(parts[0]);
            pos[1] = int.Parse(parts[1]);

            if (pos[0] < 1 || pos[0] > 8 || pos[1] < 1 || pos[1] > 8)
            {
                Console.WriteLine("Invalid coordinates! Try again.");
                return Input(name);
            }

            return pos;
        }

        // Check same cell
        public static bool SameCell(int[] a, int[] b)
        {
            return a[0] == b[0] && a[1] == b[1];
        }

        public static bool QueenAttack(int[] queen, int[] king)
        {
            return queen[0] == king[0] || queen[1] == king[1] ||
                   Math.Abs(queen[0] - king[0]) == Math.Abs(queen[1] - king[1]);
        }

        public static bool BishopCovers(int[] bishop, int[] target)
        {
            return Math.Abs(bishop[0] - target[0]) == Math.Abs(bishop[1] - target[1]);
        }

        public static void ChessPlay(int[] whiteQueen, BlackKing blackKing, int[] blackBishop)
        {
            int[] kingCoords = blackKing.ToArray();

            // Validation
            if (SameCell(whiteQueen, kingCoords) || SameCell(whiteQueen, blackBishop) || SameCell(kingCoords, blackBishop))
            {
                Console.WriteLine("Invalid position! Two pieces cannot be on the same square.");
                return;
            }

            // Queen attack
            if (QueenAttack(whiteQueen, kingCoords))
            {
                if (BishopCovers(blackBishop, whiteQueen))
                {
                    Console.WriteLine("Defence! Black bishop covers the white queen.");
                }
                else
                {
                    Console.WriteLine("Attack! White queen attacks black king.");
                }
            }
            else
            {
                Console.WriteLine("Simple move. No attack.");
            }
        }

        public static void Main()
        {
            int[] whiteQueen = Input("White Queen");

            Console.WriteLine("Enter coordinates of Black King (x y):");
            string[] parts = Console.ReadLine().Split();
            BlackKing blackKing = new BlackKing(int.Parse(parts[0]), int.Parse(parts[1]));

            int[] blackBishop = Input("Black Bishop");

            ChessPlay(whiteQueen, blackKing, blackBishop);
        }
    }
}
