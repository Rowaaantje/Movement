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
	class SimpleBall : SpriteNode
	{
		// your private fields here
		int xSpeed = 300;

		int ySpeed = 300;


		private void xAxis()
		{
			
		}

		private void yAxis()
		{
			
		}


		// constructor + call base constructor
		public SimpleBall() : base("resources/bigball.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
			Color = Color.YELLOW;
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
			Position.X += xSpeed * deltaTime;
			Position.Y += ySpeed * deltaTime;

		}

		private void BounceEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_heigth = TextureSize.Y;

			// TODO implement...
			// X
			if (Position.X > scr_width - spr_width / 2)
			{
				{
					xSpeed = xSpeed * -1;
					Position.X = scr_width - spr_width / 2;
				}
			}
			
			if (Position.X < 0 + spr_width / 2)
			{
				{
					xSpeed = xSpeed * -1;
					Position.X = 0 + spr_width / 2;
				}
			}

			
			// Y
			if (Position.Y > scr_height - spr_heigth / 2)
			{
				{
					ySpeed = ySpeed * -1;
					Position.Y = scr_height - spr_heigth / 2;
				}
			}
			
			if (Position.Y < 0 + spr_heigth / 2)
			{
				{
					ySpeed = ySpeed * -1;
					Position.Y = 0 + spr_heigth / 2;
				}
			}
		}
	}
}
