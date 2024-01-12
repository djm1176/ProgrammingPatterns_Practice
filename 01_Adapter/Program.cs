internal class Program {
	public static void Main (string[] args) {
		// Demonstrate the ILaunchable
		RocketLauncher launcher = new RocketLauncher();
		Console.WriteLine("Rocket Launcher (ILaunchable):");
		launcher.Launch();

		// Demonstrate the IShootable
		MachineGun gun = new MachineGun();
		Console.WriteLine("Machine Gun (IShootable):");
		gun.Shoot();

		// Demonstrate the Adapter from IShootable to ILaunchable
		RocketLauncherAdapter adapter = new RocketLauncherAdapter(launcher);
		Console.WriteLine("Rocket Launcher Adapter (IShootable):");
		adapter.Shoot();
	}
}