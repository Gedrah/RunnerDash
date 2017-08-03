using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RunnerDash
{
    class Animation
    {
        Texture2D currentAnimation;
        string currentAnimationName;

        Texture2D[] Animations;
        string[] animationNames;
        int[] frames;

        public Animation(Texture2D[] anims, string[] animNames, int[] nbrframes)
        {
            Animations = anims;
            Frames = nbrframes;
            animationNames = animNames;
            currentAnimation = Animations[0];
            CurrentAnimationName = AnimationNames[0];
        }

        public void ChangeAnimation(int pos)
        {
            currentAnimation = Animations[pos];
        }


        public Texture2D CurrentAnimation { get => currentAnimation; set => currentAnimation = value; }
        public string[] AnimationNames { get => animationNames; set => animationNames = value; }
        public string CurrentAnimationName { get => currentAnimationName; set => currentAnimationName = value; }
        public int[] Frames { get => frames; set => frames = value; }
    }
}