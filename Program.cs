// StackNoParams
void StackNoParams(int toCreate) {

	ValueType[] valueArray = new ValueType[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
	}

	foreach (ValueType dbl in valueArray) {Console.WriteLine(dbl);}
}

//

Console.WriteLine("StackNoParams:");
StackNoParams(5);
Snippet.LineBreak();



// // Stack Overflow
// void StackOver() {StackOver();}
// StackOver();