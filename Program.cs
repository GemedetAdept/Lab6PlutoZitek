// CS 1400 — Lab 6: Memory

// Step 000: Function which creates five value-type variables.
void StackNoParams() {

	int createdInteger = 35;
	float createdFloat = 4.003f;
	double createdDouble = 384.0003;
	decimal createdDecimal = 842.083M;
	char createdChar = 'Z';
}

StackNoParams();


int withParamsInt = 3_845;
double withParamsDouble = 829.0305;
char withParamsChar = 'Y';
void StackWithParams(int inputInteger, double inputDouble, char inputChar) {

}

StackWithParams(withParamsInt, withParamsDouble, withParamsChar);

Console.ReadKey();
