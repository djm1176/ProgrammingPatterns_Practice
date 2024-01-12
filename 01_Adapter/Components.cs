using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ILaunchable {
	public void Launch ();
}

interface IShootable {
	public void Shoot ();
}

class RocketLauncher : ILaunchable {
	public void Launch () {
		Console.WriteLine("Rocket Launcher launches!");
	}
}

class MachineGun : IShootable {
	public void Shoot () {
		Console.WriteLine("Explosive Projectile shoots!");
	}
}


// Adapts a launching weapon into a shootable one instead
class RocketLauncherAdapter : IShootable {

	// We will adapt a RocketLauncherAdapter instance, which is an IShootable, into a RocketLauncher
	RocketLauncher launcher;

	public RocketLauncherAdapter (RocketLauncher launcher) {
		this.launcher = launcher;
	}

	public void Shoot () {
		launcher.Launch();
	}
}