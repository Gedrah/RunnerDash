using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace RunnerDash
{
    class Background
    {
        private int NBR_BACKGROUND = 50;
        private Texture2D background;
        private Texture2D background2;
        private Texture2D background3;

        private int speedback1 = 0;
        private int speedback2 = 0;
        private int speedback3 = 0;
        private SpriteFont font;


        public Background()
        {

        }

        public void Init(Game game)
        {
            background = game.Content.Load<Texture2D>("far");
            background2 = game.Content.Load<Texture2D>("sand");
            background3 = game.Content.Load<Texture2D>("foreground-1");
            font = game.Content.Load<SpriteFont>("File");
        }

        public void Update(GameTime gameTime)
        {
            if (speedback1 > background.Width * 2)
            {
                speedback1 = 0;
                speedback2 = -2;
                speedback3 = -3;
            }

            speedback1++;
            speedback2 = speedback2 + 2;
            speedback3 = speedback3 + 3;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < NBR_BACKGROUND; i++)
            {
                spriteBatch.Draw(background, new Rectangle(i * background.Width - speedback1, 0, background.Width * 2, background.Height * 2), Color.White);
                spriteBatch.Draw(background2, new Rectangle(i * background2.Width - speedback2, 100, background2.Width * 2, background2.Height * 2), Color.White);
                spriteBatch.Draw(background3, new Rectangle(i * background3.Width - speedback3, 150, background3.Width * 2, background3.Height * 2 + 10), Color.White);
                i++;
            }
            spriteBatch.DrawString(font, "Background 1 : " + speedback1.ToString(), new Vector2(100, 100), Color.Black);
            spriteBatch.DrawString(font, "Background 2 : " + speedback2.ToString(), new Vector2(100, 150), Color.Black);
            spriteBatch.DrawString(font, "Background 3 : " + speedback3.ToString(), new Vector2(100, 200), Color.Black);

        }

    }
}