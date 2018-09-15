// A Hello World! program in C#.
using System;
using System.Text;
namespace api
{
    public class Engine 
    {
        public string Calculate(int totalnumber)
        {
            bool isLarger = false;
            int lastInit = 1;
            string LargerResult = "";

            do
            {
                StringBuilder sb = new StringBuilder();
                int target = 0;
                int running = lastInit;

                for (int i = lastInit; i < totalnumber; i++)
                {
                    target += running;
                    sb.Append(" " + running);
                    running++;

                    if (target >= totalnumber) break;
                }

                if (target == totalnumber)
                {
                    LargerResult = sb.ToString();
                }
                else if (lastInit == totalnumber)
                {
                    isLarger = true;
                }
                lastInit++;

            } while (lastInit <= totalnumber);

                        
            return LargerResult = !string.IsNullOrEmpty(LargerResult) ? LargerResult.ToString().Trim() : "This number no consecutive number";
        }

    }
}