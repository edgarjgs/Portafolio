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
