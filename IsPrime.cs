namespace try1
{
   public class IsPrime
    {
       public bool IsPrime1(int num)
        {
            for (int z = 2; z * z <= num; z++)
            {
                if (num % z == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
