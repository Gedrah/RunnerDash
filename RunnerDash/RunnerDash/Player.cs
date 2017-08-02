using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RunnerDash
{
    class Player
    {
        Vector2 pos;
        Animation anim;
        Vector2 framePos;

        public Player()
        {
            pos = new Vector2(0, 0);
            framePos = new Vector2(0, 0);
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

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(anim.CurrentAnimation, new Rectangle(50, 0, anim.CurrentAnimation.Width * 2, anim.CurrentAnimation.Height * 2), Color.White);
            //
            spriteBatch.End();
        }
    }

}