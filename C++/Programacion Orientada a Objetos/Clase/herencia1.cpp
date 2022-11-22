
#include "stdafx.h"
#include <iostream>
using namespace std;

class aritmetica1
{
public:
	double suma(double num1, double num2)
	{
		return (num1 + num2);
	}
	double resta(double num1, double num2)
	{
		return(num1 - num2);
	}
};

class aritmetica2:public aritmetica1
{
public:
	double multi(double num1, double num2)
	{
		return(num1 * num2);
	}
	double divide(double num1, double num2)
	{
		return(num1 / num2);
	}
};
int main()
{
	aritmetica2 obj1;
	cout << obj1.suma(20, 5) << endl;
	system("pause");
    return 0;
}

