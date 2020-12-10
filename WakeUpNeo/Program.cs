using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WakeUpNeo
{
    class Program
    {
        #region Sentences for Neo

        private const string wakeUpNeo = "Wake up, Neo...";
        private const string theMatrixHasYou = "The Matrix has you...";
        private const string followTheWhiteRabbit = "Follow the white rabbit.";
        private const string knockKnockNeo = "Knock, knock, Neo";

        #endregion

        #region Entity

        static Random random = new Random();
        static int sleepTime = 150;

        #endregion

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            DoSAtackOnNeo(wakeUpNeo);
    
            Thread.Sleep(3000);
            Console.Clear();

            DoSAtackOnNeo(theMatrixHasYou, true);

            Thread.Sleep(5000);
            Console.Clear();

            DoSAtackOnNeo(followTheWhiteRabbit, true);

            Thread.Sleep(7000); 
            Console.Clear();

            Console.Write(knockKnockNeo);
            Thread.Sleep(13000);
        }

        public static void DoSAtackOnNeo(string sentence, bool needRandom = false)
        {
            if (needRandom)
                sleepTime = random.Next(150, 250);
            else
                sleepTime = 150;

            foreach (char letter in sentence)
            {  
                Console.Write(letter);
                Thread.Sleep(sleepTime);
            }
        }
    }
}
