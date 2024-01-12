abstract class Shape {
	public int BoundsX, BoundsY, BoundsZ;

	public Color? color; // Some shapes may not care about color!

	public Shape (int boundsX, int boundsY, int boundsZ) {
		BoundsX = boundsX;
		BoundsY = boundsY;
		BoundsZ = boundsZ;
	}

	public override string ToString () {
		string colorStr = "uncolored";

		if (color != null) {
			// Shoddy way to get a name of the shade 

			float brightness = (color.R + color.G + color.B) / 3;
			string brightStr = brightness == 1f ? "white" : brightness == 0f ? "black" : brightness > 0.66f ? "bright" : brightness > 0.33f ? "" : "dark";

			string shadeStr = color.R > (color.G + color.B) / 2f ? "red" : color.G > (color.R + color.B) / 2f ? "green" : color.B > (color.R + color.G) / 2f ? "blue" : color.R == color.G && color.G == color.B && brightness != 0 && brightness != 1 ? "grey" : "";

			colorStr = shadeStr != "" && brightStr != "" ? $"{brightStr} {shadeStr}" : brightStr != "" ? $"{brightStr}" : $"{shadeStr}";
		}

		return $"Shape has bounds of ({BoundsX}, {BoundsY}, {BoundsZ}) and is {colorStr}!";

	}
}

class Square : Shape {
	public Square (int sideLength) : base(sideLength, sideLength, sideLength) { }
}

class Circle : Shape {
	public Circle (int radius) : base(radius * 2, radius * 2, radius * 2) { }
}

class Prism : Shape {
	public Prism (int width, int height, int length) : base(width, height, length) { }
}

/* Rather than define UncoloredSquare, ColoredSquare, UncoloredCircle, ColoredCircle, ...,
 * we allow the Shapes to contain an instance of a Color class, as all Shapes may or may not have color
 */
class Color {
	public float R, G, B;

	public Color (float r, float g, float b) {
		R = r; G = g; B = b;
	}
}