internal class Program {
	public static void Main(string[] args) {
		Restaurant beefRestaurant = new BeefBurgerRestaurant();
		Restaurant veggieRestaurant = new VeggieBurgerRestaurant();

		Burger beefBurger = beefRestaurant.OrderBurger();
		Burger veggieBurger = veggieRestaurant.OrderBurger();
	}
}