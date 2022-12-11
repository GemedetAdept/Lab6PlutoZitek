public class ValueType {

	private double _value;

	public ValueType() {

		Value = Double.MaxValue;
	}

	public double Value {

		get {return _value;}
		set {_value = value;}
	}
}