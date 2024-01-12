internal class Program {
	public static void Main (string[] args) {
		// Get the singleton instance
		GlobalProgramState instance = GlobalProgramState.Instance;

		// Note that we can't create our own instance of the singleton class
		// GlobalProgramState instance = new GlobalProgramState();

		Console.WriteLine($"The singleton instance reports startup time of {instance.StartupTime}");

	}
}