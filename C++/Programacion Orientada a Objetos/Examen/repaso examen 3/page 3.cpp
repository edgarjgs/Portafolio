#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

template <class X>
void f(X a)
{
	cout << a << " ";
}
template <class X, class Y>
void f(X a, Y b)
{
	cout << a * b << " ";
}

int main()
{
	int x;
	for (x = 1; x < 4; x++)
	{
		f(x);
		cout << '\n';
		f(x, x + 4);
		cout << '\n';
	}

	system("pause");
	return 0;
}
