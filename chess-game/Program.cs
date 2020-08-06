using System;
using keyboard;
using game;

namespace chessGame
{
  class Program
  {
    static void Main(string[] args)
    {
      try {

      Keyboard keyboard = new Keyboard(8, 8);

      keyboard.placePiece(new Tower(keyboard, Color.white), new Position(0,0));
      keyboard.placePiece(new Tower(keyboard, Color.black), new Position(1,3));
      keyboard.placePiece(new King(keyboard, Color.black), new Position(2,4));

      Screen.printKeyboard(keyboard);   

      } catch (Exceptions e) {
        Console.WriteLine(e.Message);
      }
    }
  }
}
