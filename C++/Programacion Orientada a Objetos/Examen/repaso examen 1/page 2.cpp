
#include "pch.h"
#include "stdafx.h"
#include <iostream>
using namespace std;

class example
{
	int a, b, c;
public:
	example();
	example(int d, int e, int f);
	void show_variables();
};
example::example()
{
	a = 200; b = 220; c = 500;
}
example::example(int d, int e, int f)
{
	a = d; b = e; c = f;
}
void example::show_variables()
{
	cout << a << " " << b << " " << c << endl;
}
void main(void)
{
	example obj1, obj2(25, 346, 220);
	obj1.show_variables();
	obj2.show_variables();
}