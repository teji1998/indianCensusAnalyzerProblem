using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyzerProblem
{
    public class CensusAnalyserException :Exception
    {
        public enum ExceptionType
        {
            FILE_NOT_FOUND,INCORRECT_DELIMITER,INCORRECT_HEADER,NO_SUCH_FILE_TYPE,INVALID_COUNTRY
        }

        public ExceptionType type;

        public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
        {
            this.type = exceptionType;
        }
    }
}
