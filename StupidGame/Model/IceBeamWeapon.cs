using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StupidGame.View;


namespace StupidGame
{
	public class IceBeamWeapon
	{

		// Image representing the Projectile
		private Animation iceBeamAnimation;
		// Animation representing the enemy
		public Animation IceBeamAnimation

		{
			get { return iceBeamAnimation; }
			set { iceBeamAnimation = value; }
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
		private Viewport viewPort;


		private float iceBeamMoveSpeed;
		// Determines how fast the projectile moves
		public float IceBeamMoveSpeed
		{
			get { return iceBeamMoveSpeed; }
			set { iceBeamMoveSpeed = value; }
		}


		public void Initialize(Viewport viewPort, Animation animation, Vector2 position)
		{
			this.viewPort = viewPort;
			this.iceBeamAnimation = animation;
			this.position = position;
			Active = true;
			Damage = 4;
			iceBeamMoveSpeed = 50f;
		}

		public void Update()
		{
			// Projectiles always move to the right
			Position.X += iceBeamMoveSpeed;
			position.Y += 0;

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			//spriteBatch.Draw(Animation, position, null, Color.White, position.Y*3,
			//	 Vector2.Zero, 2f, SpriteEffects.None, 0f);

			// Draw the animation
			iceBeamAnimation.Draw(spriteBatch);
		}
	}
}

