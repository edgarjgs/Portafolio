#include "stdafx.h"
//#include "pch.h"
#include <iostream>

using namespace std;

class matrix
{
	double my_array[10][10];
	int n;

public:
	void entrada_numeros();
	matrix(int x);
	void imprime_matriz();
	matrix operator+(matrix matrix_obj);
	matrix operator=(matrix matrix_obj);
};

void matrix::entrada_numeros()
{
	int x, y;
	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			cout << "Entre un numero en el lugar " << x << " " << y << endl;
			cin >> my_array[x][y];
		}
	}
}

matrix::matrix(int x)
{
	n = x;
}

void matrix::imprime_matriz()
{
	int x, y;
	cout << endl;
	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			cout << my_array[x][y] << "  ";
		}
		cout << endl;
	}
	cout << endl;
}

matrix matrix::operator+(matrix matrix_obj)
{
	matrix temp_obj(n);
	int x, y;
	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			temp_obj.my_array[x][y] = my_array[x][y] + matrix_obj.my_array[x][y];
		}
	}
	return temp_obj;
}

matrix matrix::operator=(matrix matrix_obj)
{
	int x, y;
	for (x = 0; x < n; x++)
	{
		for (y = 0; y < n; y++)
		{
			my_array[x][y] = matrix_obj.my_array[x][y];
		}
	}
	return *this;
}

int main()
{
	matrix my_matrix_ob1(2);
	matrix my_matrix_ob2(2);
	matrix my_matrix_ob3(2);
	my_matrix_ob1.entrada_numeros();
	//	my_matrix_ob1.imprime_matriz();
	my_matrix_ob2.entrada_numeros();

	my_matrix_ob3 = my_matrix_ob1 + my_matrix_ob2;
	my_matrix_ob1.imprime_matriz();
	my_matrix_ob2.imprime_matriz();
	my_matrix_ob3.imprime_matriz();
	system("pause");
	return 0;
}
