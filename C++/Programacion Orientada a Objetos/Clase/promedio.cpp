
#include "pch.h"

#include <iostream>
using namespace std;

class promedio_est
{
	int nota[4];
	//	int promedio_m = 0;
public:
	void input();
	void promedio_b();
};

void promedio_est::input()
{
	int t;
	for (t = 0; t < 4; t++)
	{
		cout << "Entre nota " << t + 1 << endl;
		cin >> nota[t];
	}
}

void promedio_est::promedio_b()
{
	int x, total;
	double promedio_m;
	total = 0;
	for (x = 0; x < 4; x++)
	{
		total = total + nota[x];
	}
	promedio_m = total / 4;
	cout << "El promedio es " << promedio_m << endl;
}

int main()
{
	int x;

	promedio_est obj_promedio[3];
	for (x = 0; x < 3; x++)
	{
		obj_promedio[x].input();
		obj_promedio[x].promedio_b();
	}
	system("pause");
	return 0;
}