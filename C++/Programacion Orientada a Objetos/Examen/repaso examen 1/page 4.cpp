
#include "pch.h"
#include "stdafx.h"
#include <iostream>
using namespace std;

class sumatres
{
private:
	int x, y, z;
public:
	sumatres(int a, int b, int c)
	{
		x = a; y = b; z = c;
	}
	int suma()
	{
		return(x + y + z);
	}
};

void main(void)
{
	sumatres d(150, 210, 320);
	cout << d.suma() << endl;
}