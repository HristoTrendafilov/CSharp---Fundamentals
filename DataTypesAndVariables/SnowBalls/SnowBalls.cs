using System;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());

            var snowballSnowMax = 0;
            var snowballTimeMax = 0;
            var snowballQualityMax = 0;
            

            double bestSnowBall = 0;

            for (int i = 0; i < snowBalls; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                double snowBallValue = Math.Pow(snowBallSnow / snowBallTime, snowBallQuality);


                if (snowBallValue > bestSnowBall)
                {
                    snowballSnowMax = snowBallSnow;
                    snowballTimeMax = snowBallTime;
                    snowballQualityMax = snowBallQuality;
                    bestSnowBall += snowBallValue;
                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {bestSnowBall} ({snowballQualityMax})");
        }
    }
}
