using keyboard;

namespace game {
  class Tower : Piece {
    public Tower (Keyboard board, Color color) : base (board, color) {}

    public override string ToString() {
      return "T";
    }
  }
}