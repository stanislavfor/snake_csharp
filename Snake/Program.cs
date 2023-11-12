
// Console.WriteLine("Hello, World!");
// Console.ReadLine();
int x1 = 1;
int y1 = 3;
char sym1 = '*';
Draw(x1, y1, sym1);

int x2 = 4;
int y2 = 5;
char sym2 = '#';
// Console.SetCursorPosition(x2, y2);
// Console.Write(sym2);
// Console.ReadLine();
Draw(x2, y2, sym2);

int x3 = 7;
int y3 = 8;
char sym3 = '*';
Draw(x3, y3, sym3);


void Draw(int x, int y, char sym) {
  Console.SetCursorPosition(x, y);
  Console.Write(sym);
};
