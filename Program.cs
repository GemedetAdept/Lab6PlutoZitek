using menudriver;

MenuDriver selectionMenu = new MenuDriver();
string[] options = new string[] {
	"StackNoParams",
	"StackWithParams",
	"HeapNoParams",
	"HeapWithParams",
	"StackWithHeap",
	"StackOver",
	"Exit Program",
};
selectionMenu.AddOptions(options);

void mainMenu() {
	while (selectionMenu.menuLoop){

		Console.Clear();
		selectionMenu.DisplayMenu();
		selectionMenu.SetMenuCursor();

		switch(selectionMenu.selectedItem) {

			case 0:
				StackNoParams(5);
				Console.ReadKey();
				break;
			case 1:
				StackWithParams(5, Double.MaxValue);
				Console.ReadKey();
				break;
			case 2:
				HeapNoParams(999999);
				Console.ReadKey();
				break;
			case 3:
				HeapWithParams(5, new string('A',100_000_000));
				Console.ReadKey();
				break;
			case 4:
				StackWithHeap(999999, 999999, 999999, 999999, Double.MaxValue, new string('A',100_000_000));
				Console.ReadKey();
				break;
			case 5:
				StackOver();
				Console.ReadKey();
				break;
			case 6:
				Environment.Exit(0);
				break;
			default:
				break;
		}
	}
}

mainMenu();

// -------------------------------------------------------------------------------

ValueType[] StackNoParams(int toCreate) {

	ValueType[] dataArray = new ValueType[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		dataArray[i] = newValue;
	}

	return dataArray;
}

double[] StackWithParams(int toCreate, double setValue) {

	double[] dataArray = new double[toCreate];
	for (int i=0; i < toCreate; i++) {
		ValueType newValue = new ValueType();
		newValue.Value = setValue;
		dataArray[i] = newValue.Value;
	}

	return dataArray;
}

ReferenceType[] HeapNoParams(int toCreate) {

	ReferenceType[] dataArray = new ReferenceType[toCreate];
	for (int i=0; i < toCreate; i++) {
		ReferenceType newValue = new ReferenceType();
		dataArray[i] = newValue;
	}

	return dataArray;
}

string[] HeapWithParams(int toCreate, string setReference) {

	string[] dataArray = new string[toCreate];
	for (int i=0; i < toCreate; i++) {
		ReferenceType newReference = new ReferenceType();
		newReference.Reference = setReference;
		dataArray[i] = newReference.Reference;
	}

	return dataArray;
}

void StackWithHeap(int valueParamsCount, int refParamsCount, int valueVarsCount, 
	int refVarsCount, double setValue, string setReference) {

	ValueType[] valueVarsArray = StackNoParams(valueVarsCount);
	double[] valueParamsArray = StackWithParams(valueParamsCount, setValue);

	ReferenceType[] refVarAray = HeapNoParams(refVarsCount);
	string[] refParamsArray = HeapWithParams(refParamsCount, setReference);

}

void StackOver() {StackOver();}