using System;

namespace ClassLibrary
{
    public class SquaredArray
    {
        private double[] array;

        public SquaredArray(int size)
        {
            array = new double[size];
        }

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс находится вне диапазона массива.");
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = Math.Pow(value, 2);
                }
                else
                {
                    throw new IndexOutOfRangeException("Индекс находится вне диапазона массива.");
                }
            }
        }
    }
}
