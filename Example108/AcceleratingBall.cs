using System.Numerics; // Vector2
using Raylib_cs; // Color
using System;

/*
In this class, we have the properties:

- Vector2  Position
- float    Rotation
- Vector2  Scale

- Vector2 TextureSize
- Vector2 Pivot
- Color Color

Methods:

- AddChild(Node child)
- RemoveChild(Node child, bool keepAlive = false)
*/

namespace Movement
{
	class AcceleratingBall : MoverNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)
		private float MaxSpeed;

		

		// constructor + call base constructor
		public AcceleratingBall() : base("resources/ball.png")
		{
			Velocity = new Vector2();
			Acceleration = new Vector2();
			MaxSpeed = 1000f;
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
			Color = Color.RED;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Acceleration = new Vector2(40,30);
			Velocity = Limit(Velocity, MaxSpeed);
			Move(deltaTime);
			WrapEdges();
			Console.WriteLine(Velocity.Length());
		}
		// your own private methods
	}
}
