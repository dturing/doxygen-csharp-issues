
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