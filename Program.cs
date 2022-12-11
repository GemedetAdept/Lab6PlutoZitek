// StackNoParams
void StackNoParams(int toCreate) {

	ValueType[] valueArray = new ValueType[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		valueArray[i] = newValue;
	}

	foreach (ValueType dbl in valueArray) {Console.WriteLine(dbl);}
}

// StackWithParams
void StackWithParams(int toCreate, double setValue) {

	double[] valueArray = new double[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		newValue.Value = setValue;
		valueArray[i] = newValue.Value;
	}

	foreach (double dbl in valueArray) {Console.WriteLine(dbl);}	
}

Console.WriteLine("StackNoParams:");
StackNoParams(5);
Snippet.LineBreak();

Console.WriteLine("StackWithParams:");
StackWithParams(5, Double.MaxValue);
Snippet.LineBreak();

// // Stack Overflow
// void StackOver() {StackOver();}
// StackOver();