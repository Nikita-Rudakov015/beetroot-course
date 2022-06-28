using System;

namespace Lesson13.Inheritance
{
    public class Duck
    {
        private readonly Noise _noise;

        public Duck (Noise noise)
        {
            this._noise = noise;
        }

        public virtual void MakeNoise()
        {
            this._noise.MakeNoise();
        }
    }
}
