using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BigData3Phone
{
    //https://docs.google.com/document/d/1UG7J-zjkEa9RozFI_7aYJNfLlA_fLzuT/edit
    //https://drive.google.com/drive/folders/1ADC6OVsLLY2YSMnnl2XoGGQWNUgWcYko?hl=ru
    public class BigData3Phone
    {
        //https://docs.google.com/spreadsheets/d/1cxUjV1qm2t37L4QVdUw4c3BrsvtzAu3_/edit?gid=1278660216#gid=1278660216
        // А таблице указаны только исходящие звонки -> можно забить на стоймость входящих звонков
        // SMS тоже можно игнорировать
        
        

        #region Билайн
        public class TariffCommunicationMonster
        {
            public float FirstMinutePrice;
            public float TowToNineMinutesPrice;
            public float StartFromTenMinutesPrice;

        }

        public class WantToSay  
        {
            public float UntilSixMinutesPrice;
            public float FromSixMinutesPrice;

        }

        public class MoreWords
        {
            public float MothPrice;
            public int MothIncludedMinutes;
            public float MinutesPriceAfterExpireIncludedMinutesPrice;
        }
        #endregion

        public class ThirtyThreeCents
        {
            protected Dictionary<string, float> FirstMinutePrice= new Dictionary<string, float>();

            public float FromSecondMinutesPrice;

        }

        public class ManyCalls
        {
            public float FromFiveToThirtyOneMinutePrice;
            public float FromSixToThirtyMinutePrice;
        }
    }
}
