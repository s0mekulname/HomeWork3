using System;

namespace Model
{
    public class NewNumberEventArgs: EventArgs
    {
        public int Number { get; }

        public NewNumberEventArgs(int number)
        {
            Number = number;
        }
    }
}
