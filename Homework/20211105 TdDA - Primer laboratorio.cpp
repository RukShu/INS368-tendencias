#include <iostream>
using namespace std;

typedef long long ll;

ll max_i = 50, f = 1, f_old = 0, f_number = 0;
string digits [10] = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

bool is_prime(ll x){
	for(ll i = 2; i * i <= x ; i++){
		if(x % i == 0) return false;
	}
	return true;
}

void next_f(){
	ll temp = f;
	f = f + f_old;
	f_old = temp;
}

string separate_digits(ll x){
	string result = "";
	while(x != 0){
		int digit = x%10;
		result = digits[digit] + result;
		x /= 10;
		if(x != 0) result = "," + result;

	}
	return result;
}

void output(){
	string fib_data = " : ";
	if(f % 2 == 0) fib_data += "Par, ";
	else fib_data += "Impar, ";
	if(is_prime(f)) fib_data += "Primo, ";
	else fib_data += "No primo, ";
	fib_data += "\'" + separate_digits(f) + "\'";
	cout << f_number << ". " << f << fib_data << '\n';
	f_number++;
}

int main() {
	for(int i = 0; i <= max_i; i++){
		output();
		next_f();
	}
	return 0;
}
