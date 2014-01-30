using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiotAPITest.Models
{
    public class PlayerStatsSummaryDto
    {
        public ReturnAggregatedStats aggregatedStats;
        public int? losses;
        public long modifyDate;
        public string playerStatSummaryType;
        public int? wins;
        
        public PlayerStatsSummaryDto()
        {

        }
    }
}
