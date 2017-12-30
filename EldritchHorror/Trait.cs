namespace EldritchHorror
{
    class Trait
    {
        int baseValue;
        int incValue;

        public Trait(int startValue)
        {
            if (startValue > 4)
            {
                startValue = 4;
            }
            baseValue = startValue;
        }

        public bool Improve()
        {
            if (incValue >= 2)
            {
                return false;
            }

            incValue += 1;
            return true;
        }

        public int Total()
        {
            return baseValue + incValue;
        }
    }
}
