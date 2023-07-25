#include<iostream>
#include<cmath>
using namespace std;

bool isprime(int num){
    for(int i;i<=sqrt(num);i++){
    if( num%i == 0 ){
        return false;
    }
    return true;
}
}

int main(){
    
    int a,b;
    cin>>a;
    cin>>b;
    
    for(int i=a;i<=b;i++){
        if(isprime(i)){
            cout<<i<<", ";
        }
    }
    
    }
