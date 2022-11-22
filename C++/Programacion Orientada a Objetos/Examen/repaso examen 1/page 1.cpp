#include "pch.h"
#include "stdafx.h"
#include <iostream>
using namespace std;

class Counter
{
private:
	int count, x, y;

public:
	Counter()
	{
		count = 0;
		cout << "i'm the constructor" << endl;
	}
	Counter(int a, int b)
	{

		count = a + b;
		cout << "i'm the constructor a+b" << endl;
	}
	void inc_count()
	{
		count = count + 1;
	}
	void get_count()
	{
		cout << count << endl;
	}
};

int main(void)
{
	Counter a;
	a.inc_count();
	a.get_count();
	Counter b(300, 1170);
	b.get_count();
	//   return 0;
}