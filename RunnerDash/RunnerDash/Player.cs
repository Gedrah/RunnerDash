using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RunnerDash
{
    class Player
    {
        Vector2 pos;
        Animation anim;
        int frame;
        private const float delay = 100; // milliseconds
        private float remainingDelay = delay;

        public Player()
        {
            pos = new Vector2(0, 0);
            frame = 0;
        }

        public void Init(Game game)
        {
            Texture2D[] tab = new Texture2D[]
            {
                game.Content.Load<Texture2D>("Player/movePlayer"),
                game.Content.Load<Texture2D>("Player/jumpPlayer"),
                game.Content.Load<Texture2D>("Player/deathPlayer"),
            };

            string[] stringtab = new string[]
            {
                "move",
                "jump",
                "death"
            };

            int[] nbrframes = new int[]
            {
                6,
                2,
                1
            };

            anim = new Animation(tab, stringtab, nbrframes);
        }

        public void Update(GameTime gameTime)
        {
            var timer = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            remainingDelay -= timer;

            if (remainingDelay <= 0)
            {
                if (frame == anim.Frames[0] - 1)
                {
                    frame = 0;
                }
                else
                {
                    frame++;
                }
                remainingDelay = delay;
            }
 
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle box = new Rectangle(anim.CurrentAnimation.Width / 6 * frame, 0, anim.CurrentAnimation.Width / 6, anim.CurrentAnimation.Height);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, null, Matrix.CreateScale(0.2f));

            spriteBatch.Draw(anim.CurrentAnimation, new Rectangle(2000, 200, anim.CurrentAnimation.Width / 6, anim.CurrentAnimation.Height), box, Color.White);
            
            spriteBatch.End();
        }
    }

}