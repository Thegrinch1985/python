#include <iostream>

using namespace std;

enum players

{

	Fred,
	Paul,
	Jim,
	Allen,
	playersCount
};

/*
Enums allow you create your own data types that can have specific values
this allows you to use them in your classes. you can apply logic operators 
to them.

In this class we have four players, each has a different value
associated to them.

the scores(scores) method takes an enum data type players , and returns the value of that
enum. If for example it takes scores(Fred) it will take the 
value of the players enum that is equal to fred, in this case it will outputv5




*/

int& scores(players challegers) {

	static int scoreCard[playersCount];
	return scoreCard[challegers];


}
int main() {

	scores(Fred) = 5;
	scores(Paul) = 10;
	scores(Jim) = 15;
	scores(Allen) = 20;

	//if(players == Jim)

	cout << scores(Fred) << " " << endl;
	cout << scores(Paul) << " " << endl;
	cout << scores(Jim) << " " << endl;
	cout << scores(Allen) << " " << endl;
	cout << playersCount << endl;
	system("pause");

	return 0;


}