using System;

namespace Properties
{
    class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;

        public int Width { get; set; }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                length, height, width, volume = width * height * length);
        }
    }
}
