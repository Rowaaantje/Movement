using System; // Console
using System.Numerics; // Vector2
using Raylib_cs; // Color

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
	class Pointer : MoverNode
	{
		// your private fields here (add Velocity, Acceleration, and MaxSpeed)


		// constructor + call base constructor
		public Pointer() : base("resources/spaceship.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
			Color = Color.YELLOW;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			PointToMouse(deltaTime);
			BounceEdges();
		}

		// your own private methods
		private void PointToMouse(float deltaTime)
		{
			Vector2 mouse = Raylib.GetMousePosition();
            Vector2 dir = mouse - Position;
            Acceleration = Vector2.Normalize(dir) * 1800.0f;

			
            
            // Console.WriteLine(mouse);
            Velocity += Acceleration * deltaTime;
            Position += Velocity * deltaTime;
            Acceleration *= 0;
            Rotation = Math.Atan2(Velocity.Y, Velocity.X);
		}
	}
}
