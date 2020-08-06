namespace keyboard {
  class Keyboard {
    public int lines;
    public int columns;
    private Piece[,] boardPieces;

    public Keyboard(int lines, int columns) {
      this.lines = lines;
      this.columns = columns;
      boardPieces = new Piece[lines, columns];
    }

    public Piece piece (int line, int column) {
      return boardPieces[line, column];
    }
    public Piece piece (Position position) {
      return boardPieces[position.line, position.column];
    }

    public void placePiece (Piece piece, Position position) {
      freePlace(position);
      boardPieces[position.line, position.column] = piece;
      piece.position = position;
    }

    public bool freePlace (Position position) {
      validate(position);
      if (piece(position) != null) ThrowException("Unfree Position!");
      return true;
    }

    public bool validate (Position position) {
      int line = position.line, column = position.column;
      if (line < 0 || line >= this.lines || column < 0 || column >= this.columns) {
        ThrowException("Invalid Position!");
      }
      return true;
    }

    public void ThrowException (string message) => throw new Exceptions(message);
  }
}