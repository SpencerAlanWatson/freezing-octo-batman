using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RiotAPITest.Models
{
    public class cChampionDto
    {
        string name;
        long id;

        bool active;

        bool botEnabled;
        bool botMmEnabled;

        int attackRank;
        int magicRank;
        int defenseRank;
        int difficultyRank;

        bool freeToPlay;
        bool rankedPlayEnabled;
    }
}