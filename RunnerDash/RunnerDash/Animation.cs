using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RunnerDash
{
    class Animation
    {
        Texture2D currentAnimation;

        Texture2D[] Animations;
        string[] AnimationNames;
        int[] frames;

        public Animation(Texture2D[] anims, string[] animNames, int[] nbrframes)
        {
            Animations = anims;
            frames = nbrframes;
            AnimationNames = animNames;
            currentAnimation = Animations[0];
        }

        public void ChangeAnimation(int pos)
        {
            currentAnimation = Animations[pos];
        }


        public Texture2D CurrentAnimation { get => currentAnimation; set => currentAnimation = value; }
        public string[] AnimationNames1 { get => AnimationNames; set => AnimationNames = value; }
    }
}