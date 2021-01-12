using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * model = 
               {
                    throwCount: 0,
                    dice: [ 
                        {value: 1, isLocked: false},
                        {value: 2, isLocked: false},
                        {value: 3, isLocked: false},
                        {value: 4, isLocked: false},
                        {value: 5, isLocked: false},
                    ],
               }
             */
            var yatzyDice = new YatzyDice();
            // ...
            //var random = new Random();
            //foreach (var die in model.Dice)
            //{
            //    if (die.IsLocked) continue;
            //    die.Value = random.Next(1, 7);
            //}

            //foreach (var die in model.Dice)
            //{
            //    die.Roll();
            //}

            yatzyDice.Roll();
        }

        //public static void DoSomeMagic(YatzyDice yatzyDice)
        //{

        //}
    }
}
