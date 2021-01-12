using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    class InitializedArrayFactory
    {
        public static T[] Create<T>(int count) where T : new()
        {
            var list = new T[count];
            for (var i = 0; i < list.Length; i++)
            {
                list[i] = new T();
            }
            return list;
        }
    }
}
