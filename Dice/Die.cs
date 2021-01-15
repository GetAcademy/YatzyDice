using System;

namespace Dice
{
    class Die
    {
        private static readonly Random Random = new Random();

        public int Value { get; private set; }

        private bool _isLocked;

        //static Die()
        //{
        //    Random = new Random();
        //}

        public Die()
        {
            Value = 6;
            _isLocked = false;
        }

        public void Roll(bool forcedThrowAndReset = false)
        {
            if (forcedThrowAndReset || !_isLocked) Value = Random.Next(1, 7);
            if (forcedThrowAndReset)
            {
                _isLocked = false;
            }
        }
    }
}
