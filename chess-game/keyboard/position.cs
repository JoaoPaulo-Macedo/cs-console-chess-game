namespace keyboard {
  class Position {
    public int line;
    public int column;

    public Position(int line, int column) {
      this.line = line;
      this.column = column;
    }

    public override string ToString(){
      return line + ", " + column;
    }
  }
}