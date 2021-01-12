using System;

namespace Dice
{
    class Die
    {
        private static readonly Random Random = new Random();

        private int _value;
        private bool _isLocked;

        //static Die()
        //{
        //    Random = new Random();
        //}

        public Die()
        {
            _value = 6;
            _isLocked = false;
        }

        public void Roll(bool forcedThrowAndReset = false)
        {
            if (forcedThrowAndReset || !_isLocked) _value = Random.Next(1, 7);
            if (forcedThrowAndReset)
            {
                _isLocked = false;
            }
        }
    }
}
