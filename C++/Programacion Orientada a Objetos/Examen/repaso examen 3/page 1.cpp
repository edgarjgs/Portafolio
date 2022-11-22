#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

template <class X>
void power(X &a, X &b)
{
	cout << a * b << endl;
	a = a - 2;
	b = b - 4;
}

int main()
{
	int c, d;
	c = 50;
	d = 30;
	power(c, d);
	cout << c << " " << d << endl;
	system("pause");
	return 0;
}
