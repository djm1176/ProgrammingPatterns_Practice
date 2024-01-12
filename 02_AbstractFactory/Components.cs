/* Abstract Factory Notes
 *  - Explicitly declare interfaces for each distinct product
 * 
 * 
 *
 */

// Abstract Product
internal interface Monitor {
	void Assemble ();
}

// Abstract Product
internal interface GPU {
	void Assemble ();
}

// Abstract Product
internal interface Motherboard {
	void Assemble ();
}

/* Concrete Implementations
 * Each concrete product implementation correlates the referenced Abstract Product to the factory that creates it
 */

internal class MsiMonitor : Monitor {
	public void Assemble () {
		Console.WriteLine("Assembling an MSI Monitor!");
	}
}

internal class AsusMonitor : Monitor {
	public void Assemble () {
		Console.WriteLine("Assembling an ASUS Monitor!");
	}
}

internal class MsiGpu : GPU {
	public void Assemble () {
		Console.WriteLine("Assembling an MSI GPU!");
	}
}

internal class AsusGpu : GPU {
	public void Assemble () {
		Console.WriteLine("Assembling an ASUS GPU!");
	}
}

internal class MsiMotherboard : Motherboard {
	public void Assemble () {
		Console.WriteLine("Assembling an MSI Motherboard!");
	}
}

internal class AsusMotherboard : Motherboard {
	public void Assemble () {
		Console.WriteLine("Assembling an ASUS Motherboard!");
	}
}