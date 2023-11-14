namespace try1
{

    public class Darsha
    {
        public double majmo1;

        public double majmo2;

        public double majmo3;

        public void dars3setare()
        {
            for (int i = 0; i < 5; i++)
            {
                double point = Random.Shared.Next(0, 21);
                point *= 3;
                majmo1 += point;

            }

        }

       public void dars2setare()
        {
            for (int i = 5; i < 8; i++)
            {
                double point = Random.Shared.Next(0, 21);
                point *= 2;
                majmo2 += point;
            }

        }
       public void dars1setare()
        {
            for (int i = 8; i < 10; i++)
            {
                double point = Random.Shared.Next(0, 21);
                point *= 1;
                majmo3 += point;
            }
        }

    }

}
