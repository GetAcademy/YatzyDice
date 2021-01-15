using System;
using System.Linq;
using System.Text;

namespace Dice
{
    class YatzyDice
    {
        private Die[] _dice;
        private int _throwCount;

        public YatzyDice()
        {
            //Program.DoSomeMagic(this);
            _throwCount = 0;
            _dice = new Die[]
            {
                new Die(),
                new Die(),
                new Die(),
                new Die(),
                new Die(),
            };

            //Dice = new Die[5];
            //for (int i = 0; i < Dice.Length; i++)
            //{
            //    Dice[i] = new Die();
            //}

            //Dice = Enumerable.Repeat(1, 5)
            //    .Select(n=>new Die())
            //    .ToArray();

            //Dice = InitializedArrayFactory.Create<Die>(5);
        }

        public void Roll()
        {
            var isLastThrow = _throwCount == 2;
            foreach (var die in _dice)
            {
                die.Roll(isLastThrow);
            }
            _throwCount++;
        }

        public string GetDiceValuesAsString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var die in _dice)
            {
                stringBuilder.Append(die.Value);
                //die.Value = 5;
            }

            return stringBuilder.ToString();
        }
    }
}
