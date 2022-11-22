//#include "stdafx.h"
#include "pch.h"
#include <iostream>

using namespace std;

class region
{
public:
	double uyu(double);
	double cup(double);
	double jpy(double);
	double pab(double);

};
int main()
{
	region change;
	int select;
	double cantidad;
	double test;

	cout << "Cambio de moneda" << endl;
	cout << "Entrar valor de cantidad cual quieras cambiar" << endl;
	cin >> cantidad;
	test = cantidad;
	cout << "Escoja la region a la cual quieres cambiar la cantidad \n seleccione entre 1-4" << endl;
	cout << "(1) Uruguay \n(2) Cuba \n(3) Japon \n(4) Panama" << endl;
	cin >> select;


	switch (select)
	{
	case 1:

		cout << "\n" << test << " Dolares de Estados Unidos es igual a " << change.uyu(cantidad) << " en Uruguay" << endl;
		break;
	case 2:
		cout << "\n" << test << " Dolares de Estados Unidos es igual a " << change.cup(cantidad) << " en Cuba" << endl;
		break;
	case 3:
		cout << "\n" << test << " Dolares de Estados Unidos es igual a " << change.jpy(cantidad) << " en Japon" << endl;
		break;
	case 4:
		cout << "\n" << test << " Dolares de Estados Unidos es igual a " << change.pab(cantidad) << " en Panama" << endl;
		break;
	default:
		cout << "\n No hay ninguna region en el numero escrito.\n";
	}
	return 0;
}
double region::uyu(double x)
{
	double const uyu1 = 31.4932;
	x = x * uyu1;
	return x;
}
double region::cup(double x)
{
	double const cup1 = 1.00000;
	x = x * cup1;
	return x;
}
double region::jpy(double x)
{
	double const jpy1 = 110.335;
	x = x * jpy1;
	return x;
}
double region::pab(double x)
{
	double const pab1 = 1.00000;
	x = x * pab1;
	return x;
}
/*
#include "stdafx.h"
#include "pch.h"
#include <iostream>
using namespace std;
int main()
{
	   int usd;
	   double uyu,cup,jpy,pab;

	   cout<<"Entrar valor $ estadounidense"<<endl;
	   cin>>usd;

		uyu=usd*31.4932;
		cup=usd*1.00000;
		jpy=usd*110.335;
		pab=usd*1.00000;

	   cout<<usd<<" Dolares de Estados Unidos es igual a "<<uyu<<" en Uruguay"<<endl;
	   cout<<usd<<" Dolares de Estados Unidos es igual a "<<cup<<" en Cuba"<<endl;
	   cout<<usd<<" Dolares de Estados Unidos es igual a "<<jpy<<" en Japon"<<endl;
	   cout<<usd<<" Dolares de Estados Unidos es igual a "<<pab<<" en Panama"<<endl;

	   system("pause");
}

}*/