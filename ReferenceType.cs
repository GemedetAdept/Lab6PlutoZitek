public class ReferenceType {

	private string _reference;

	public ReferenceType() {

		Reference = new string('A',100_000_000);
	}

	public string Reference {

		get {return _reference;}
		set {_reference = value;}
	}
}