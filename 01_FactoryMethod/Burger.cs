public abstract class Burger {
	public int productId;
	public string? addOns;

	public abstract Burger Prepare();
}

public class BeefBurger : Burger {

	public bool angus;

	public override Burger Prepare() { 
		Burger burger = new BeefBurger();
		burger.productId = 1;
		((BeefBurger)burger).angus = true;

		Console.WriteLine("Prepared a Beef Burger!");
		
		return burger;
	}
}

public class VeggieBurger : Burger {

	public bool redOnions;

	public override Burger Prepare() {
		Burger burger = new VeggieBurger();
		burger.productId = 2;
		((VeggieBurger)burger).redOnions = true;

		Console.WriteLine("Prepared a Veggie Burger!");

		return burger;
	}

}