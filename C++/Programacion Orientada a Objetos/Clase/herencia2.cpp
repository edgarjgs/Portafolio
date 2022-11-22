
#include "stdafx.h"
#include <iostream>
using namespace std;

class mayor_menor
{
public:
	double mayor(double num1, double num2)
	{
		if (num1 > num2) 
		{
			return(num1);
		}
		else
		{
			return (num2);
		}
	}
	double menor(double num1, double num2)
	{
		if (num1 < num2)
		{
			return(num1);
		}
		else
		{
			return (num2);
		}
	}


};


class multiplicador:public mayor_menor
{
public:
	double nmp2(double num1, double num2)
	{
		return(2 * mayor(num1, num2));
	}
	double nmp4(double num1, double num2)
	{
		return(4 * menor(num1, num2));
	}
};
int main()
{ 
	multiplicador obj1;
	cout << obj1.nmp2(20,5) << endl;
	cout << obj1.nmp4(20,5) << endl;
	system("pause");
    return 0;
}

