namespace try1
{
    public class IfElse
    {
        
        public double majmo4;

        public void IfElse1()
        {
            string grade;
            if (majmo4 > 17)
            {
                grade = "A";
            }
            else if (majmo4 > 15)
            {
                grade = "B";
            }
            else if (majmo4 > 13)
            {
                grade = "C";
            }
            else if (majmo4 > 10)
            {
                grade = "D";
            }
            else if (majmo4 > 7)
            {
                grade = "E";
            }
            else if (majmo4 > 3)
            {
                grade = "F";
            }
            else
            {
                grade = "G";
            }
            Console.WriteLine(grade);
        }

    }

}
