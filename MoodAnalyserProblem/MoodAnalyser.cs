using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyserMethod()
        {
            try
            {

                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }

            catch
            {
                return "HAPPY";
            }

        }
    }
}