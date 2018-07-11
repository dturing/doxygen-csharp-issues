# doxygen-csharp-issues

demonstrating some issues with doxygen and C#

## Klass vs Klass<T>

Doxygen doesn't properly differentiate a non-generic and a generic class of the same name.

```
/// <summary>This is the non-generic Klass</summary>
class Klass {
}

/// <summary>This is the generic Klass<T></summary>
class Klass<T> {
}
```

Yes, this is valid C#.

Both classes turn up in the class list, but they link to the same html file, effectively hiding one of those classes.

## Implementing a generic nested interface

```
/// <summary>This is the generic MyClass<T></summary>
class MyClass<T> {

	/// <summary>Here's the nested interface MyClass<T>.MyNestedInterface</summary>
	interface MyNestedInterface {

		/// <summary>Just some function</summary>
		void MyFunction();
	}
}

/// <summary>This is MyImplementation<T> implementing MyClass<T>.MyNestedInterface</summary>
class MyImplementation<T> : MyClass<T>.MyNestedInterface {

	void MyFunction() {
	}
}
```

I'm not all sure we even need the generic types, but if you look at the generated documentation for MyImplementation<T>, you'll see doxygen thinks it derives from "MyClassMyNestedInterface< T >".

## Inheriting property documentation

```
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
```

I would expect all of foo, bar and baz to turn up as members of SomeClass (they do), but with inherited documentation from SomeInterface (they don't). Instead, they turn up twice, once as SomeClass' members, and again (with docs) as "... inherited from SomeInterface".
