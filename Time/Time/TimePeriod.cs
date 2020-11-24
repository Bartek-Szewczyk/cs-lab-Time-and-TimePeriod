using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Time
{
    struct TimePeriod
    {
        private Time time { get; }
        private byte Hour { get; set; }
        private byte Minutes { get; set; }
        private byte Seconds { get; set; }
    }
}
