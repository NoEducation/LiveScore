using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballApi.Infrastructure
{
    public class ResponseManager
    {
        private RequestCreator requestCreator;
        public ResponseManager()
        {
            requestCreator = new RequestCreator();
        }


        public async void Test()
        {
            var response = await requestCreator.CreateRequest(QueryCreator.SetQueryChampionLeagueMatches);

        }

    }
}
