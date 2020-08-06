using keyboard;

namespace game {
  class King : Piece {
    public King (Keyboard board, Color color) : base (board, color) {}

    public override string ToString() {
      return "R";
    }
  }
}