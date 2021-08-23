using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            NO_SUCH_CONSTRUCTOR
        }
        public readonly ExceptionType type;

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
