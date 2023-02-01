namespace Calculator

{
    public static class mycalculator
    {






        // The whole number above the one given
        public static double Ceiling(double x)
        {
            int answer = 0;
            for (int i = 0; i <= x; i++)
            {
                int answerr = i;
                answer = answerr;
            }

            double realanswer = answer += 1;
            return realanswer;

        }
        public static double Ceiling(decimal x)
        {
            int answer = 0;
            for (int i = 0; i <= x; i++)
            {
                int answerr = i;
                answer = answerr;
            }

            double realanswer = answer += 1;
            return realanswer;

        }




// The whole number below the one given

        public static double Floor(double x)
        {
            int answer = 0;
            for (int i = 0; i <= x; i++)
            {
                int answerr = i;
                answer = answerr;
            }


            return answer;
        }

         public static double Floor(decimal x)
        {
            int answer = 0;
            for (int i = 0; i <= x; i++)
            {
                int answerr = i;
                answer = answerr;
            }
            return answer;
        }

    // What pie equals
        public const double PI = 3.1415926535897931;
        


    // Is it a positive or negitive
        public static double Sign(double x)
        {
            if (x > 0)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
            
        }
        public static double Sign(int x)
        {
            if (x > 0)
            {
                return 1;
            }
            else 
            {
                return -1;
            }
            
        }




        // Multiple the first number by itself by the second number of times
        public static double exponet(double x, double y)
        {
            double ans = 1;
            for (int i = 0; i < y; i++)
            {
                double growth = ans * x;
                ans = growth;
            }
            return ans;
        }
          public static double exponet(int x, int y)
        {
            double ans = 1;
            for (int i = 0; i < y; i++)
            {
                double growth = ans * x;
                ans = growth;
            }
            return ans;
        }





        //finds the square root of any number

        public static double Square(double x)
        {
            double o = 0;
            double t = 0;
            for (o = 1; o < x; o += 0.0000001)
            {
                t = o;
                double answer = o * t;
                if (x <= answer)
                {
                    break;

                }
            }
            
            return o;
        }
         public static double Square(int x)
        {
            double o = 0;
            double t = 0;
            for (o = 1; o < x; o += .00000001)
            {
                t = o;
                double answer = o * t;
                if (x <= answer)
                {
                    break;

                }
            }
            
            return o;
        }




    //finds the absolute value of the number
        public static double AbsoluteValue(double x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return x * -1;
            }


        }
        public static double AbsoluteValue(float x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return x * -1;
            }


        }
        public static int AbsoluteValue(int x)
        {
            if (x > 0)
            {
                return x;
            }
            else
            {
                return x * -1;
            }


        }


        //What number is greater
        public static double Max(int x, int y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }

        }
        public static double Max(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }

        }


        //what number is less then the other
        public static double Min(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }

        }

        public static double Min(double x, double y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }

        }











    // add 2 numbers
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }


        //subtract 2 numbers
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        public static float Subtract(float x, float y)
        {
            return x - y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        //multiply 2 numbers
        public static int Mulitply(int x, int y)
        {
            return x * y;
        }

        public static float Mulitply(float x, float y)
        {
            return x * y;
        }

        public static double Mulitply(double x, double y)
        {
            return x * y;
        }

    // divide 2 numbers
        public static double Divide(int x, int y)
        {
            return x / y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static decimal Divide(decimal x, decimal y)
        {
            return x / y;
        }

    }







}