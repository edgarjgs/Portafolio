#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

class region
{
public:
	double atm(int, double, double);
	double math(double, double);
	double rem(double, double);
};

int main()
{
	region change;
	int s = 0, yn;
	double balanceM = 100;
	double b = 0;
	cout << "Cuenta de banco: \n\n";

	do
	{
		cout << "Que quieres hacer: \n (1) Estado de la cuenta \n (2) Anadir dinero \n (3) Retirar dinero \n Cualquier otro numero cerrara la cuenta \n";
		cin >> s;
		change.atm(s, balanceM, b);
		balanceM = balanceM + b;
		cout << "Quieres continuar con la cuenta? \n (1) si  (2) no \n";
		cin >> yn;

	} while (yn == 1);
	{
		return 0;
	}
}

double region::atm(int s, double balance2, double x)
{
	region change;
	double retire;
	double add;
	// int s;
	double balance = 0;
	// s = y;
	/*cout << "Cuenta de banco: \n\n";
	cout << "Que quieres hacer: \n (1) Estado de la cuenta \n (2) Anadir dinero \n (3) Retirar dinero \n Cualquier otro numero cerrara la cuenta \n";
	cin >> s; */
	balance = balance2 + balance;

	switch (s)
	{
	case 1:
		cout << "Balance de la cuenta: $" << balance << endl;
		x = balance + balance2;
		return x;
		break;
	case 2:

		cout << "Anadir dinero a la cuenta: $";
		cin >> add;
		balance = balance + add;
		cout << "Balance de la cuenta: $" << balance << endl;
		x = balance2 + balance;
		return x;
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
			return x;
		}
		else
		{
			change.math(retire, balance);
			cout << "Usted retiro: $" << retire << endl;
			cout << "Nuevo Balance: $" << change.math(retire, balance) << endl;
			x = balance2 + balance;
			return x;
		}
		break;

	default:
		cout << "Cerrando la cuenta" << endl;
		break;
		return 0;
	}
	return 0;
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
