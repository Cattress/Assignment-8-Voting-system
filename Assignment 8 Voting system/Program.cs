using System;

namespace Assignment_8_Voting_system
{
    class Program
    {
       static void Main(string[] args)
        {
            Vote[] votes = new Vote[1000000];
            CastVotes(votes);
            int[] totals = PartyTotal(votes);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(totals[i]);
            }
        }
        


        static void CastVotes(Vote[] votes)
        {
            int VoteNumber = -1;
            int i = 0;

            while (VoteNumber != 0)
            {
               
                Console.WriteLine("What's your name?");
                string nameInput = Console.ReadLine();
                  
                Console.WriteLine("Enter your vote:");
                string VoteInput = Console.ReadLine();
                VoteNumber = Convert.ToInt32(VoteInput); 
                //  ^^converts input to int rather than string, allows for interaction^^

                if (VoteNumber == 0)
                {
                    Console.WriteLine("Ending system...");
                }
                else if (VoteNumber == 1)
                {
                    votes[i] = new Vote("Communist", nameInput);
                }
                else if (VoteNumber == 2)
                {
                    votes[i] = new Vote("Democrat", nameInput);
                }
                else if (VoteNumber == 3)
                {
                    votes[i] = new Vote("Fascist", nameInput);
                }
                i++;
            }


        }

        static int[] PartyTotal(Vote[] votes)
        {
            int ComTotal = 0;
            int DemTotal = 0;
            int FasTotal = 0;
           for (int i=0; i<votes.Length; i++)
            {
                if (votes[i] != null)
                {
                   if (votes[i].GetPartyName() == "Communist")
                    {
                        ComTotal++;
                    }
                    if (votes[i].GetPartyName() == "Democrat")
                    {
                        DemTotal++;
                    }
                    if (votes[i].GetPartyName() == "Facist")
                    {
                        FasTotal++;
                    }
                }
            }

            int[] totals = new int[3];
            totals[0] = ComTotal;
            totals[1] = DemTotal;
            totals[2] = FasTotal;

            return totals;
         
        }

        static void TopVotes(Vote[] votes, int[] totals)
        {
            int TotalVotes = Vote.GetTotalVotes();

            int ComPercent = (totals[0] / TotalVotes)*100;
            int DemPercent = (totals[1] / TotalVotes)*100;
            int FasPercent = (totals[2] / TotalVotes)*100;


            if (ComPercent > 50 )
            {
                Console.WriteLine("Communists won by " + ComPercent + " %");
            }
            else if (DemPercent > 50)
            {
                Console.WriteLine("Democrats won by " + DemPercent + " %");
            }
            else if (FasPercent > 50)
            {
                Console.WriteLine("Facists won by " + FasPercent + " %");
            }
            else
            {
                Console.WriteLine("No Party got over 50%");
            }

        }

    }
}
