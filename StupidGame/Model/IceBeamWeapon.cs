using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;



namespace StupidGame
{
	public class IceBeamWeapon
	{
		// Image representing the Projectile
		private Texture2D texture;

		public Texture2D Texture
		{
			get { return texture; }
			set { texture = value; }
		}

		// Position of the Projectile relative to the upper left side of the screen
		private Vector2 position;
		public Vector2 Position
		{
			get { return position; }
			set { position = value; }
		}


		private bool active;
		// State of the Projectile
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}


		private int damage;
		// The amount of damage the projectile can inflict to an enemy
		public int Damage
		{
			get { return damage; }
			set { damage = value; }
		}

		// Represents the viewable boundary of the game
		Viewport viewport;

		// Get the width of the projectile ship
		public int Width
		{
			get { return Texture.Width; }
		}

		// Get the height of the projectile ship
		public int Height
		{
			get { return Texture.Height; }
		}


		private float iceBeamMoveSpeed;
		// Determines how fast the projectile moves
		public float IceBeamMoveSpeed
		{
			get { return iceBeamMoveSpeed; }
			set { iceBeamMoveSpeed = value; }
		}


		public void Initialize(Texture2D texture, Vector2 position)
		{
			this.texture = texture;
			this.position = position;
			Active = true;
			Damage = 4;
			iceBeamMoveSpeed = 50f;
		}

		public void Update()
		{
			// Projectiles always move to the right
			Position.X += iceBeamMoveSpeed;
			//position.Y += 0;

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, position, null, Color.White, position.Y*3,
				 Vector2.Zero, 2f, SpriteEffects.None, 0f);
		}
	}
}

