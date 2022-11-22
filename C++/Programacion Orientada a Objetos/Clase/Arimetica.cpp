#include <iostream>
using namespace std;

class Arimetica
{
  int num1, num2;

public:
  void set_values(int, int);
  int num3() { return num1 + num2; };
  int num4() { return num1 - num2; };
  int num5() { return num1 / num2; };
  int num6() { return num1 * num2; };
};

void Arimetica::set_values(int x, int y)
{
  num1 = x;
  num2 = y;
}

int main()
{
  Arimetica rect;
  rect.set_values(3, 4);
  cout << "sum: " << rect.num3();
  cout << "  rest: " << rect.num4();
  cout << "  div: " << rect.num5();
  cout << "  mult: " << rect.num6();
  return 0;
}

