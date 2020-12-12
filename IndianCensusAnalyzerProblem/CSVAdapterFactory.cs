using IndianCensusAnalyzerProblem.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyzerProblem
{
    public class CSVAdapterFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndiaCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("Country which is given is invalid", CensusAnalyserException.ExceptionType.INVALID_COUNTRY);
            }
        }
    }
}
