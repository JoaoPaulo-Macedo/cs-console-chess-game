using keyboard;

namespace game {
  class ChessPosition {
    public char column;
    public int line;

    public ChessPosition(char column, int line) {
      if (column >= 97) column = (char) (column - 32);
      this.column = column;
      this.line = line;
    }

    public Position toPosition() {
      return new Position(8 - line, column - 'A');
    }

    public override string ToString() {
      return "" + column + line;
    }
  }
}