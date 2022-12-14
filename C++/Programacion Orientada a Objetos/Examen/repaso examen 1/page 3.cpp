
#include "pch.h"
#include "stdafx.h"
#include <iostream>
using namespace std;

class cuenta_bancaria
{
private:
	double balance;
public:
	void balance_inicial(double a)
	{
		balance = a;
	}
	void deposito(double a)
	{
		balance = balance + a;
	}
	void retiro(double a)
	{
		if (a <= balance)
		{
			cout << "Retiro de " << a << endl;
			balance = balance - a;
			cout << "Nuevo balance = " << balance << endl;
		}
		else
		{
			cout << "No hay fondos disponibles" << endl;
			cout << "Su balance actual es " << balance << endl;
		}
	}
	void imprime_balance()
	{
		cout << "Su balance es " << balance << endl;
	}
};

void main(void)
{
	cuenta_bancaria e01, e02;
	e01.balance_inicial(1000.0);
	e01.imprime_balance();
	e01.retiro(1500);
	e01.imprime_balance();
	e01.retiro(400);
	e01.deposito(500);
	e01.imprime_balance();
	e01.deposito(4500);
	e01.imprime_balance();
	e02.balance_inicial(300);
	e02.imprime_balance();
}