namespace keyboard {
  class Piece {
    public Position position;
    public Color color {get; protected set;}
    public Keyboard board {get; protected set;}
    public int movements {get; protected set;}

    public Piece(Keyboard board, Color color) {
      movements = 0;
      this.position = null;
      this.board = board;
      this.color = color;
    }
  }
}