#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

class region
{
public:
	double math(double, double);
	double rem(double, double);
};

int main()
{
	region change;
	double retire;
	double balance = 100;
	double add;
	int s;
	cout << "Cuenta de banco: \n\n";
	cout << "Que quieres hacer: \n (1) Estado de la cuenta \n (2) Anadir dinero \n (3) Retirar dinero \n Cualquier otro numero cerrara la cuenta \n";
	cin >> s;

	switch (s)
	{
	case 1:
		cout << "Balance de la cuenta: $" << balance << endl;
		system("pause");
		break;
	case 2:

		cout << "Anadir dinero a la cuenta: $";
		cin >> add;
		balance = balance + add;
		cout << "Balance de la cuenta: $" << balance << endl;
		system("pause");
		break;

	case 3:

		cout << "Remover dinero de la cuenta \n\n"
			 << "Balance de la cuenta: $" << balance << endl;
		cout << "Cuento dinero quieres retirar?" << endl
			 << "$";
		cin >> retire;

		if (retire > balance)
		{
			cout << "No se puede retirar mas dinero de lo que hay en la cuenta, Ya que su balance seria: $" << change.rem(balance, retire) << endl;
			system("pause");
		}
		else
		{
			change.math(retire, balance);
			cout << "Usted retiro: $" << retire << endl;
			cout << "Nuevo Balance: $" << change.math(retire, balance) << endl;
			system("pause");
		}
		break;

	default:
		cout << "Cerrando la cuenta" << endl;
		system("pause");
		return 0;
		break;
	}
}
double region::math(double s, double b)
{
	s = b - s;
	return s;
}
double region::rem(double s, double b)
{
	b = s - b;
	return b;
}
