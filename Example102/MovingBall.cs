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
	
	class MovingBall : SpriteNode
	{
		// your private fields here (add Velocity)
		
		Vector2 velocity;
		
		


		// constructor + call base constructor
		public MovingBall() : base("resources/dvdlogo.png")
		{
			velocity = new Vector2(300,200); //velocity = new Vector2(X, Y);

			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
			Color = Color.ORANGE;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Move(deltaTime);
			BounceEdges();
		}

		// your own private methods
		private void Move(float deltaTime)
		{
			// TODO implement
			Position += velocity * deltaTime;
		}

		private void BounceEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_heigth = TextureSize.Y;

			// TODO implement...
			// x
			if (Position.X > scr_width - spr_width / 2)
			{
				{
					velocity.X *= -1;
					Position.X = scr_width - spr_width / 2;
				}
			}
			
			if (Position.X < 0 + spr_width / 2)
			{
				{
					velocity.X *= -1;
					Position.X = 0 + spr_width / 2;
				}
			}

			
			// Y
			if (Position.Y > scr_height - spr_heigth / 2)
			{
				{
					velocity.Y *= -1;
					Position.Y = scr_height - spr_heigth / 2;
				}
			}
			
			if (Position.Y < 0 + spr_heigth / 2)
			{
				{
					velocity.Y *= -1;
					Position.Y = 0 + spr_heigth / 2;
				}
			}
		}

	}
}
