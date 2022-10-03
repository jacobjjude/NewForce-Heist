using System;

namespace heist
{
    public class Bank
    {
        public int CashOnHand {get; set;}
        public int AlarmScore {get; set;}
        public int VaultScore {get; set;}
        public int SecurityGuardScore {get; set;}
        public bool isSecure
        {
            get
            {
                if (this.SecurityGuardScore <= 0 || this.AlarmScore <=0 || this.VaultScore <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}