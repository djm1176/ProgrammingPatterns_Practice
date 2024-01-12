using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents the state of the program during execution. There should only ever be 1 instance.
/// </summary>
internal class GlobalProgramState {

	// Define the singleton
	private static GlobalProgramState? instance = null;
	
	// Provide a public property to access the singleton, or create it on first access
	public static GlobalProgramState Instance { get {
			if (instance == null) {
				instance = new GlobalProgramState();
			}

			return instance;
		}
	}

	// Class members
	public DateTime StartupTime { get; private set; } = default;


	// Disallow creation of the singleton class outside of itself
	private GlobalProgramState () {
		StartupTime = DateTime.Now;
	}

}
