#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

template <class  type1, class type2, class type3>
void myfunc(type1 x,type2 y, type3 z)
{
	type2 Total;
	type3 Promedio;
	Total = (y + z) * 2;
	Promedio = Total / 2;
	cout << z << " " << x << " " << y << " " << Total << " " << Promedio << "\n";

}



int main()
{
	myfunc("Maria", 20, 5);
	myfunc("Carmelo", 10, 15);	

	
	system("pause");
    return 0;
}

