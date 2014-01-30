using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPITest.Models
{
    public class ReturnAggregatedStats
    {
        public string playerStatSummaryType;
        public int? wins;
        public int? losses;

        public int? normalGamesPlayed;
        public int? botGamesPlayed;
        public int? rankedPremadeGamesPlayed;
        public int? rankedSoloGamesPlayed;
        public int? maxTimePlayed;

        public int? totalDamageDealt;
        public int? maxLargestCriticalStrike;
        public int? totalPhysicalDamageDealt;
        public int? totalMagicDamageDealth;
        public int? totalHeal;
        public int? totalDamageTaken;
        public int? maxNumDeaths;                  //Ranked only
        public int? totalDeathsPerSession;         //Ranked only
        public int? maxTimeSpentLiving;
        public int? mostSpellsCast;

        public int? totalGoldEarned;

        public int? maxChampionsKilled;
        public int? totalChampionKills;
        public int? totalAssists;
        public int? mostChampionKillsPerSession;
        public int? totalFirstBlood;
        public int? totalDoubleKills;
        public int? totalTripleKills;
        public int? totalQuadraKills;
        public int? totalPentaKills;
        public int? totalUnrealKills;
        public int? killingSpree;
        public int? maxLargestKillingSpree;

        public int? totalTurretsKilled;
        public int? totalMinionKills;
        public int? totalNeutralMinionsKilled;

        public int? averageAssists;                //Dominion Only
        public int? averageChampionsKilled;        //Dominion Only
        public int? averageCombatPlayerScore;      //Dominion Only 
        public int? averageNodeCapture;            //Dominion Only
        public int? averageNodeCaptureAssist;      //Dominion Only
        public int? averageNodeNeutralize;         //Dominion Only
        public int? averageNodeNeutralizeAssist;   //Dominion Only
        public int? averageNumDeaths;              //Dominion Only
        public int? averageObjectivePlayerScore;   //Dominion Only
        public int? averageTeamObjective;          //Dominion Only
        public int? averageTotalPlayerScore;       //Dominion Only
        public int? maxAssists;                    //Dominion Only
        public int? maxCombatPlayerScore;          //Dominion Only

        public int? maxNodeCapture;                //Dominion Only
        public int? maxNodeCaptureAssist;          //Dominion Only
        public int? maxNodeNeutralize;             //Dominion Only
        public int? maxNodeNeutralizeAssist;       //Dominion Only
        public int? maxObjectivePlayerScore;       //Dominion Only
        public int? maxTeamObjective;              //Dominion Only
        public int? maxTotalPlayerScore;           //Dominion Only

        public int? totalNodeCapture;              //Dominion Only
        public int? totalNodeNeutralize;           //Dominion Only   

        public ReturnAggregatedStats()
        {

        }
    }
}