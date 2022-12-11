// StackNoParams
void StackNoParams(int toCreate) {

	double[] valueArray = new double[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		valueArray[i] = newValue.Value;
	}

	foreach (double dbl in valueArray) {Console.WriteLine(dbl);}
}

StackNoParams(5);

// // Stack Overflow
// void StackOver() {StackOver();}
// StackOver();