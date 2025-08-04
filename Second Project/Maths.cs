namespace Second_Project
{
    public class Maths
    {
        public static decimal Add(decimal num01 , decimal num02)
        {
            return num01 + num02;
        }
        public static decimal Divide(decimal num01, decimal num02)
        {
            if (num01 != 0 && num02 != 0) 
                return num01 / num02;
            else
                return 0;
        }
        public static decimal Subtract(decimal num01, decimal num02)
        {
            return num01 - num02;
        }
        public static decimal Multiply(decimal num01, decimal num02)
        {
            return num01 * num02;
        }
        
    }
}
