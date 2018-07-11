
/// <summary>This is an interface</summary>
class SomeInterface {
	/// <summary>The 'foo' read-only property is documented in SomeInterface</summary>
	public bool foo { get; }

	/// <summary>The 'bar' attribute is documented in SomeInterface</summary>
	public bool bar;

	/// <summary>The 'baz' function is documented in SomeInterface</summary>
	public bool baz();

}

/// <summary>This is a class implementing SomeInterface</summary>
class SomeClass : SomeInterface {

	public bool foo { get; }

	public bool bar;

	public bool baz() { };
}
