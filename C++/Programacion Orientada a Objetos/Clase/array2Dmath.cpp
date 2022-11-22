#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

int main()
{
	int n, x, y, a[10][10], b[10][10], c[10][10];
	cout << "Entre dimencion de la matriz " << endl;
	cin >> n;

	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			cout << "Entre un numero en el lugar " << x << " " << y << endl;
			cin >> a[x][y];
		}
	}
	for (x = 0; x < n; x++)

	{
		for (y = 0; y < n; y++)
		{
			cout << "Entre un numero en el lugar " << x << " " << y << endl;
			cin >> b[x][y];
		}
	}
	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			c[x][y] = a[x][y] + b[x][y];
		}
	}
	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			cout << c[x][y] << "  ";
		}
		cout << endl;
	}
	cout << endl;
	system("pause");
	return 0;
}