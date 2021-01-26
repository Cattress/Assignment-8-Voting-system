using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Voting_system
{
    class Votes
    {
        private string partyName;
        private DateTime TimeVoted;
        private string voterName;
        private static int totalVotes;
        private static int UserInput;


        private static Boolean ContinueVote;


        public Votes(string partyName, string voterName)
        {
            this.partyName = partyName;
            this.voterName = voterName;
            TimeVoted = DateTime.Now;
            totalVotes++;
        }
        public string GetPartyName()
        {
            return partyName;
        }

        public int GetTotalVotes()
        {
            return totalVotes;
        }


    }

}
