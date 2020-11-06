using System;

namespace MyArrayLibrary
{
    public class MyArray
    {
        int[] _a;

        public MyArray(int size, int startValue, int step)
        {
            _a = new int[size];
            for (int i = 0; i < size; i++)
            {
                _a[i] = startValue;
                startValue += step;
            }
        }

        public int this[int i]
        {
            get { return _a[i]; }
            set { _a[i] = value; }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int element in _a)
                    sum += element;
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                int maxValue = int.MinValue;
                foreach (int element in _a)
                {
                    if (element > maxValue)
                        maxValue = element;
                }
                foreach (int element in _a)
                {
                    if (element == maxValue)
                        count++;
                }
                return count;
            }
        }

        public int[] Inverse()
        {
            int size = _a.Length;
            int[] b = new int[size];
            for (int i = 0; i < size; i++)
                b[i] = -_a[i];
            return b;
        }

        public void Multi(int x)
        {
            int size = _a.Length;
            for (int i = 0; i < size; i++)
                _a[i] *= x;
        }

        public override string ToString()
        {
            string s = "";
            foreach (int element in _a)
                s += element + " ";
            return s;
        }
    }
}
