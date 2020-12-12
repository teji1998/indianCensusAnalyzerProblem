using IndianCensusAnalyzerProblem;
using IndianCensusAnalyzerProblem.POCO;
using NUnit.Framework;
using System.Collections.Generic;
using static IndianCensusAnalyzerProblem.CensusAnalyser;

namespace IndianCensusAnalyserTest
{
    public class Tests
    {
        static string indianStateCensusHeaders = "State,Population,AreaInSqKm,DensityPerSqKm";
        static string indianStateCodHeaders = "SrNo,State Name,TIN,StateCode";

        //File paths
        static string indianStateCensusFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\IndiaStateCensusData.csv";
        static string wrongHeaderIndianCensusFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\WrongIndiaStateCensusData.csv";
        static string delimeterIndianCensusFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\DelimiterIndiaStateCensusData.csv";
        static string indianStateCodeFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\IndiaStateCode.csv";
        static string wrongHeaderIndianStateCodeFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\WrongIndiaStateCode.csv";
        static string delimeterIndianStateCodeFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\DelimiterIndiaStateCode.csv";
        static string wrongIndiaCensusFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\IndiaStateCensusData.txt";
        static string wrongIndiaStateCodeFilePath = @"C:\Users\PRITHVIL5\source\repos\IndianCensusAnalyzerProblem\IndianCensusAnalyserTest\CSVFiles\IndiaStateCode.txt";
        CensusAnalyser censusAnalyser;

        Dictionary<string, CensusDTO> totalRecords;
        Dictionary<string, CensusDTO> stateRecords;

        [SetUp]
        public void Setup()
        {
            censusAnalyser = new CensusAnalyser();
            totalRecords = new Dictionary<string, CensusDTO>();
            stateRecords = new Dictionary<string, CensusDTO>();
        }

        [Test]
        public void givenIndianCensusDataFile_WhenRead_ShouldReturnCount()
        {
            totalRecords = censusAnalyser.LoadCensusData(Country.INDIA, indianStateCensusFilePath, indianStateCensusHeaders);
            Assert.AreEqual(29, totalRecords.Count);
        }
    }
}