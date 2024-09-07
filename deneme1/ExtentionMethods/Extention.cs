namespace EmployeAPI.ExtentionMethods
{
    public static class Extention
    {
        public static bool IsInteger(this double number)
        {
            bool isInteger = false;

            int numberInt =(int)number;
            if (number > numberInt) 
                isInteger = false;
            else
                isInteger = true; 

            return isInteger;
        }
    }
}
