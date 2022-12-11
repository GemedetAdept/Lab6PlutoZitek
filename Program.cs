// StackNoParams
ValueType[] StackNoParams(int toCreate) {

	ValueType[] dataArray = new ValueType[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		dataArray[i] = newValue;
	}

// foreach (ValueType i in dataArray) {Console.WriteLine(i);}
	// Console.ReadKey();
	return dataArray;
}

// StackWithParams
double[] StackWithParams(int toCreate, double setValue) {

	double[] dataArray = new double[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		newValue.Value = setValue;
		dataArray[i] = newValue.Value;
	}

// foreach (double i in dataArray) {Console.WriteLine(i);}	
	// Console.ReadKey();
	return dataArray;
}

// HeapNoParams
ReferenceType[] HeapNoParams(int toCreate) {

	ReferenceType[] dataArray = new ReferenceType[toCreate];
	for (int i=0; i < toCreate; i++) {
		ReferenceType newValue = new ReferenceType();
		dataArray[i] = newValue;
	}

// foreach (ReferenceType i in dataArray) {Console.WriteLine(i);}
	// Console.ReadKey();
	return dataArray;
}

// HeapWithParams
string[] HeapWithParams(int toCreate, string setReference) {

	string[] dataArray = new string[toCreate];
	for (int i=0; i < toCreate; i++) {
		ReferenceType newReference = new ReferenceType();
		newReference.Reference = setReference;
		dataArray[i] = newReference.Reference;
	}

// foreach (string i in dataArray) {Console.WriteLine(i);}	
	// Console.ReadKey();
	return dataArray;
}

// StackWithHeap
void StackWithHeap(int valueParamsCount, int refParamsCount, int valueVarsCount, 
	int refVarsCount, double setValue, string setReference) {

	ValueType[] valueVarsArray = StackNoParams(valueVarsCount);
	double[] valueParamsArray = StackWithParams(valueParamsCount, setValue);

	ReferenceType[] refVarAray = HeapNoParams(refVarsCount);
	string[] refParamsArray = HeapWithParams(refParamsCount, setReference);

// foreach (ValueType i in valueVarsArray) {Console.WriteLine(i);}	
// foreach (double i in valueParamsArray) {Console.WriteLine(i);}	
// foreach (ReferenceType i in refVarAray) {Console.WriteLine(i);}	
// foreach (string i in refParamsArray) {Console.WriteLine(i);}

	Console.ReadKey();
}

// Console.WriteLine("StackNoParams:");
// StackNoParams(5);
// Snippet.LineBreak();

// Console.WriteLine("StackWithParams:");
// StackWithParams(5, Double.MaxValue);
// Snippet.LineBreak();

// Console.WriteLine("HeapNoParams");
// HeapNoParams(999999);
// Snippet.LineBreak();

// Console.WriteLine("HeapWithParams");
// HeapWithParams(5, new string('A',100_000_000));
// Snippet.LineBreak();

// StackWithHeap(999999, 999999, 999999, 999999, Double.MaxValue, new string('A',100_000_000));

// // Stack Overflow
void StackOver() {StackOver();}
StackOver();
Console.ReadKey();