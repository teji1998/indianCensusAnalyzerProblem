using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyzerProblem.POCO
{
    public class CensusDataDAO
    {
        public string state;
        public long population;
        public long area;
        public long density;

        public CensusDataDAO(string state, long population,long area, long density)
        {
            this.state = state;
            this.population = Convert.ToInt32(population);
            this.area = Convert.ToInt32(area);
            this.density = Convert.ToInt32(density);
        }
    }
}
