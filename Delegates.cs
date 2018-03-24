using System;

public static class Delegates
{
	public delegate bool Predicate<T, U>(T t, U u);

	/// <summary>
	/// Creates a predicate chain that mimics a basic AND gate. True if all are true.
	/// </summary>
	public static Predicate<T> And<T>(params Predicate<T>[] predicates)
	{
		return delegate (T t)
		{
			foreach (Predicate<T> predicate in predicates)
				if (!predicate(t))
					return false;
			return true;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic NAND gate. True if at least one is false.
	/// </summary>
	public static Predicate<T> Nand<T>(params Predicate<T>[] predicates)
	{
		return delegate (T t)
		{
			foreach (Predicate<T> predicate in predicates)
				if (!predicate(t))
					return true;
			return false;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic OR gate. True if at least one is true.
	/// </summary>
	public static Predicate<T> Or<T>(params Predicate<T>[] predicates)
	{
		return delegate (T t)
		{
			foreach (Predicate<T> predicate in predicates)
				if (predicate(t))
					return true;
			return false;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic NOR gate. True if all are false.
	/// </summary>
	public static Predicate<T> Nor<T>(params Predicate<T>[] predicates)
	{
		return delegate (T t)
		{
			foreach (Predicate<T> predicate in predicates)
				if (predicate(t))
					return false;
			return true;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic XOR gate. True if results are mixed.
	/// </summary>
	public static Predicate<T> Xor<T>(params Predicate<T>[] predicates)
	{
		return delegate (T t)
		{
			bool flag = predicates[0](t);
			foreach (Predicate<T> predicate in predicates)
				if (predicate(t) != flag)
					return true;
			return false;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic XNOR gate. True if results are not mixed.
	/// </summary>
	public static Predicate<T> Xnor<T>(params Predicate<T>[] predicates)
	{
		return delegate (T t)
		{
			bool flag = predicates[0](t);
			foreach (Predicate<T> predicate in predicates)
				if (predicate(t) != flag)
					return false;
			return true;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic AND gate. True if all are true.
	/// </summary>
	public static Predicate<T, U> And<T, U>(params Predicate<T, U>[] predicates)
	{
		return delegate (T t, U u)
		{
			foreach (Predicate<T, U> predicate in predicates)
				if (!predicate(t, u))
					return false;
			return true;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic NAND gate. True if at least one is false.
	/// </summary>
	public static Predicate<T, U> Nand<T, U>(params Predicate<T, U>[] predicates)
	{
		return delegate (T t, U u)
		{
			foreach (Predicate<T, U> predicate in predicates)
				if (!predicate(t, u))
					return true;
			return false;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic OR gate. True if at least one is true.
	/// </summary>
	public static Predicate<T, U> Or<T, U>(params Predicate<T, U>[] predicates)
	{
		return delegate (T t, U u)
		{
			foreach (Predicate<T, U> predicate in predicates)
				if (predicate(t, u))
					return true;
			return false;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic NOR gate. True if all are false.
	/// </summary>
	public static Predicate<T, U> Nor<T, U>(params Predicate<T, U>[] predicates)
	{
		return delegate (T t, U u)
		{
			foreach (Predicate<T, U> predicate in predicates)
				if (predicate(t, u))
					return false;
			return true;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic XOR gate. True if results are mixed.
	/// </summary>
	public static Predicate<T, U> Xor<T, U>(params Predicate<T, U>[] predicates)
	{
		return delegate (T t, U u)
		{
			bool b = predicates[0](t, u);
			foreach (Predicate<T, U> predicate in predicates)
				if (predicate(t, u) != b)
					return true;
			return false;
		};
	}

	/// <summary>
	/// Creates a predicate chain that mimics a basic XNOR gate. True if results are not mixed.
	/// </summary>
	public static Predicate<T, U> Xnor<T, U>(params Predicate<T, U>[] predicates)
	{
		return delegate (T t, U u)
		{
			bool b = predicates[0](t, u);
			foreach (Predicate<T, U> predicate in predicates)
				if (predicate(t, u) != b)
					return false;
			return true;
		};
	}
}
