public abstract class Restaurant {

	public abstract Burger CreateBurger();

	public Burger OrderBurger() {
		Burger burger = CreateBurger();
		burger.Prepare();
		return burger;
	}
}

public class BeefBurgerRestaurant : Restaurant { 
	public override Burger CreateBurger() {
		return new BeefBurger();
	}
}

public class VeggieBurgerRestaurant : Restaurant {
	public override Burger CreateBurger() {
		return new VeggieBurger();
	}
}