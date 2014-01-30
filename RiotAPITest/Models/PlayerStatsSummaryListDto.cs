using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPITest.Models
{
    public class PlayerStatsSummaryListDto
    {
        public List<PlayerStatsSummaryDto> playerStatSummaries;
        public long summonerId;

        public PlayerStatsSummaryListDto()
        {

        }
    }
}