internal class Program {
	public static void Main (string[] args) {
		/* We may find a situation where a class with various behaviors needs to be duplicated to produce a new
		 * version. Using inheritance will quickly multiple the number of subclasses required.
		 * By using Composition instead of Inheritance, we store instance(s) representing related behavior in a class
		 * as opposed to creating many subclasses. This will separate abstraction from implementation,
		 * allowing us to develop them separately from each other
		 */

		// Define a few shapes, and use composition to decide if they have a color or not
		
		Square redSquare = new Square(5);
		redSquare.color = new Color(1, 0, 0);

		Square square = new Square(1);

		Circle whiteCircle = new Circle(3);
		whiteCircle.color = new Color(1, 1, 1);

		Circle circle = new Circle(2);

		Prism lightBlueRect = new Prism(1, 2, 3);
		lightBlueRect.color = new Color(0.5f, 0.5f, 1);

		Prism rect = new Prism(4, 5, 6);

		Prism blackRect = new Prism(10, 1, 1);
		blackRect.color = new Color(0, 0, 0);

		List<Shape> shapes = new List<Shape>() {redSquare, square, whiteCircle, circle, lightBlueRect, rect, blackRect};

		foreach (Shape shape in shapes) {
			Console.WriteLine(shape);
		}

	}
}