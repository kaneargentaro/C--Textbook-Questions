#include <iostream>
using namespace std;

//global constant vaiarable
const int arrSize = 5;

//function to print the array
void displayArray(int intArr[])
{
	for (size_t i = 0; i < arrSize; i++)
	{
		//if current position in the array the end of the array
		if (i == arrSize - 1)
		{
			//just print value and go to next line
			cout << intArr[i] << endl;
		}
		else
		{
			//otherwise print value + comma
			cout << intArr[i] << ", ";
		}
	}
}

//rotate an array k value to the right
void rotateArrayRight(int intArr[], int k)
{
	int intArrB[arrSize];
	for (size_t i = 0; i < arrSize; i++)
	{
		//Assign the current value of intArr to a new array called "B" at 
		//(the position of i (current position of intArr) + k (rotate k to the right))%total array size
		intArrB[(i + k) % arrSize] = intArr[i];
	}
	//rewrite intArr with the values of intArrB
	for (size_t i = 0; i < arrSize; i++)
	{
		intArr[i] = intArrB[i];
	}
}

//rotate an array k value to the left
void rotateArrayLeft(int intArr[], int k)
{
	//initialize temp arrays
	int intArrB[arrSize];
	int intArrC[arrSize];

	for (size_t i = 0; i < k; i++)
	{
		//Assign intArr to intArrB at k indexes (store k elements in a temp array)
		intArrB[i] = intArr[i];
	}

	for (size_t i = 0; i < arrSize; i++)
	{
		//Use intArrC as a temp array to store the value of intArr elements once shifted k times
		intArrC[i] = intArr[i + k];

	}

	//counter variable to start at the beginning of intArrB
	int j = 0;
	for (size_t i = arrSize - k; i < arrSize; i++)
	{
		//assign values from IntArrB to the end of intArrC according to k values
		intArrC[i] = intArrB[j];
		j++;
	}

	//rewrite intArr with the values of intArrB
	for (size_t i = 0; i < arrSize; i++)
	{
		intArr[i] = intArrC[i];
	}
}

void reverseArray(int intArr[])
{
	int i = arrSize, j, temp;
	j = i - 1;
	for (size_t i = 0; i < j; i++)
	{
		temp = intArr[i];
		intArr[i] = intArr[j];
		intArr[j] = temp;
		j--;
	}

}
int main()
{
	//Initialize Arrays
	int intArr[arrSize] = { 1,2,3,4,5 };

	//Display initial array
	cout << "Initial Array: ";
	displayArray(intArr);

	//Display array after modifying the array k element to the right
	int k;
	cout << "Please enter the value of k (how many times you'd like the array to shift right): ";
	cin >> k;
	cout << "Array rotated k unit to the right: ";
	rotateArrayRight(intArr, k);
	displayArray(intArr);

	//Display array after modifying the array k element to the left
	cout << "Please enter the value of k (how many times you'd like the array to shift left): ";
	cin >> k;
	cout << "Array rotated k unit to the left: ";
	rotateArrayLeft(intArr, k);
	displayArray(intArr);

	//Display array after reversing the array
	cout << "Array reversed: ";
	reverseArray(intArr);
	displayArray(intArr);

	//Pause the output window until any key is pressed
	system("pause");
}