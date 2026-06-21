using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enums
{
    /// <summary>
    /// Перечисление времени доставки
    /// </summary>
    public enum DeliveryTimeRange
    {
        NineToEleven,   // 9:00 – 11:00
        ElevenToThirteen,   // 11:00 – 13:00
        ThirteenToFifteen,  // 13:00 – 15:00
        FifteenToSeventeen, // 15:00 – 17:00
        SeventeenToNineteen,    // 17:00 – 19:00
        NineteenToTwentyOne,    // 19:00 – 21:00
    }
}
