using System;

namespace functionsSchoolStuff
{
    class FatBoye
    {
        private bool Isfat;

        public FatBoye()
        {
            Isfat = true;
        }

        public void SetFat(bool IsFat)
        {
            this.Isfat = IsFat;
        }

        public string Name()
        {
            if (Isfat)
            {
                return "shamen met beima sheli";
            }
            else
            {
                return "walla lo kaze shamen";
            }
        }
    }
}
