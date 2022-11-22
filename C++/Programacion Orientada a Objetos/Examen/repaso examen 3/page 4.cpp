#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

template <class Type1, class Type2>
class myclass
{
	Type1 i;
	Type2 j;

public:
	myclass(Type1 a, Type2 b)
	{
		i = a;
		j = b;
	}
	void show()
	{
		cout << i * 2 << ' ' << j * 2 << '\n';
	}
};

int main()
{
	myclass<int, double> ob1(10, 20.0);
	myclass<double, int> ob2(40, 50);
	ob1.show();
	ob2.show();

	system("pause");
	return 0;
}