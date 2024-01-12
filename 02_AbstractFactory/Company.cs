using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The Abstract Factory
// Very straightforward to extend to add more components by adding additional Create* abstract methods
internal abstract class Company {

	// Create factory methods, 1 for each abstract product we have inside the abstract factory class (Company)
	internal abstract GPU CreateGPU ();
	internal abstract Monitor CreateMonitor ();
	internal abstract Motherboard CreateMotherboard ();

}

/*
 * Concrete Factory Implementations
 * Each implementation respects the single responsibility principle. The concrete factories are the only component
 * responsible for the creation of the concrete products
 */

internal class MsiManufacturer : Company {
	internal override GPU CreateGPU () {
		return new MsiGpu();
	}

	internal override Monitor CreateMonitor () {
		return new MsiMonitor();
	}

	internal override Motherboard CreateMotherboard () {
		return new MsiMotherboard();
	}
}

internal class AsusManufacturer : Company {
	internal override GPU CreateGPU () {
		return new AsusGpu();
	}

	internal override Monitor CreateMonitor () {
		return new AsusMonitor();
	}

	internal override Motherboard CreateMotherboard () {
		return new AsusMotherboard();
	}
}