// classes example
#include <iostream>
#include "stdaxfh.h"
using namespace std;

class Rectangle
{
  int num1, num2;

public:
  void set_values(int, int);
  int area() { return num1 + num2; }
};

void Rectangle::set_values(int x, int y)
{
  num1 = x;
  num2 = y;
}

int main()
{
  Rectangle rect;
  rect.set_values(3, 4);
  cout << "area: " << rect.area();
  system("pause");
}