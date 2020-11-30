using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Time
{
    public struct TimePeriod
    {
        public readonly long Seconds;
        public TimePeriod(byte hour, byte minutes, byte seconds = 0)
        {
            Seconds = hour * 3600 + verify(minutes, 0, 59) * 60 + verify(seconds, 0, 59);

            byte verify(byte value, byte min, byte max) =>
                (value >= min && value <= max) ? value : throw new ArgumentException();

        }

        public TimePeriod(long seconds)
        {
            Seconds = seconds;
        }


        public override string ToString() => $"{Seconds / 3600}:{Seconds / 60 - (Seconds / 3600 * 60):D2}:{Seconds % 60:D2}";





    }
}
