internal class Program {

	// Assume we have two interfaces, A and B. We may have a situation where we'd like to add future behavior
	// that uses a class that implements A, but behavior from the interface of B. Rather than modify these
	// interfaces or classes that inherit from them, we can create a new class that implements A, stores
	// an existing instance of type B, then when we call the methods defined by interface A, we route those
	// to the relevant methods defined by interface B instead.

	public static void Main (string[] args) {
		// Demonstrate the ILaunchable
		RocketLauncher launcher = new RocketLauncher();
		Console.WriteLine("Rocket Launcher (ILaunchable):");
		launcher.Launch();

		// Demonstrate the IShootable
		MachineGun gun = new MachineGun();
		Console.WriteLine("Machine Gun (IShootable):");
		gun.Shoot();

		// Demonstrate the Adapter
		// We can "adapt" an existing ILaunchable object to look like an IShootable object,
		// since we defined an intermediary class
		RocketLauncherAdapter adapter = new RocketLauncherAdapter(launcher);
		Console.WriteLine("Rocket Launcher Adapter (IShootable):");
		adapter.Shoot();
	}
}