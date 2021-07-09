using System;

namespace _02.EnterNumbers
{
    public class ReadNumber2
    {
        private int start;
        private int end;

        public int Start
        {
            get => start;
            
            set
            {
                if (start < 1 || start > 100)
                {
                    throw new FormatException("Invalid number");
                }

                value = start;
            }
            
        }
        public int End
        {
            get => end;
            set
            {
                if (end < 1 || end > 100)
                {
                    throw new FormatException("Invalid number");
                }

                value = end;

            }
        }

        private static void ReadNumber(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
