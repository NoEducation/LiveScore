using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApi.Infrastructure
{
    public class QueryCreator
    {
        private static readonly string _urlBase = "https://api.football-data.org/v2";

        public static string SetQueryChampionLeagueMatches { get => _urlBase + "/competitions/CL/matches"; }
        public static string SetQueryPremierLeagueMatches { get => _urlBase + "/competitions/PL/matches"; }
        public static string SetQueryRealMadridUpCommingMaches { get => _urlBase + "/teams/86/matches?status=SCHEDULED"; }
        public static string SetQueryManchesterUnUpcommingMaches{ get => _urlBase + "/teams/66/matches?status=SCHEDULED"; }
        public static string SetQueryRealMadridLiveMatch { get => _urlBase + "/teams/86/matches?status=LIVE"; }
    }
}
