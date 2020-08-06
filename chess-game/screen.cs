using System;
using keyboard;

namespace chessGame {
  class Screen {
    static private ConsoleColor blue = ConsoleColor.DarkBlue;
    static private ConsoleColor black = ConsoleColor.Black;
    static private ConsoleColor white = ConsoleColor.White;
    public static void printKeyboard(Keyboard board) {
      for (int l = 0; l < board.lines; l++) {
        Console.BackgroundColor = blue;
        Console.Write(8 - l + " ");

        for (int c = 0; c < board.columns; c++) {
          if(board.piece(l, c) != null) PrintPiece(board.piece(l, c));
          else Console.Write("_ ");
        }

        Console.ResetColor();
        Console.WriteLine();
      }
      PrintBoardLetters();
    }

    static private void PrintPiece(Piece piece) {
      if (piece.color == Color.black) Console.ForegroundColor = black;
      else Console.ForegroundColor = white;
      Console.Write(piece + " ");
      Console.ForegroundColor = ConsoleColor.Gray;
    }

    static private void PrintBoardLetters() {
      Console.BackgroundColor = blue;
      Console.WriteLine("  A B C D E F G H ");
      Console.ResetColor();
    }
  }
}