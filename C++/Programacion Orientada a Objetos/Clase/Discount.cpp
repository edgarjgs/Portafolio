//#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

class discount
{
	double ammount;
	double save;
public:
	discount();
	discount(double cantidad);
    void discount1(double cantidad);
	void cal(double cantidad);
	void print();
	void print2();
	void print3();
};

discount::discount()
{
	ammount = 0;
}

discount::discount(double cantidad)
{
	ammount = cantidad;
}

void discount::discount1(double cantidad)
{
	ammount = cantidad;
}

void discount::cal(double cantidad)
{
	save = ammount * cantidad;
	ammount = ammount - save;
}

void discount::print()
{
	cout << ammount << " Antes del descuento" << endl;
}

void discount::print2()
{
	cout << ammount << " Despues del descuento" << endl;
}

void discount::print3()
{
	cout << save << " Ahorado " << endl;
}


//---------------------------------------------


int main()
{
	discount change;
	change.discount1(10);
	change.print();
	change.cal(0.10);
	change.print2();
	change.print3();


	system("pause");
}

