using System;

internal class Program {
	public static void Main (string[] args) {

		// Abstract factory pattern: Instantiate instances of our concrete factories,
		// which allows us to call the overridden, concrete factory methods CreateGPU and CreateMonitor.

		Company msi = new MsiManufacturer();
		GPU msiGPU = msi.CreateGPU();
		Monitor msiMonitor = msi.CreateMonitor(); 
		Motherboard msiMotherboard = msi.CreateMotherboard();

		msiGPU.Assemble();
		msiMonitor.Assemble();
		msiMotherboard.Assemble();

		Company asus = new AsusManufacturer();
		GPU asusGPU = asus.CreateGPU();
		Monitor asusMonitor = asus.CreateMonitor();
		Motherboard asusMotherboard = asus.CreateMotherboard();

		asusGPU.Assemble();
		asusMonitor.Assemble();
		asusMotherboard.Assemble();
	}
}