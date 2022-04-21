using System;
using System.Collections.Generic;

namespace RecountAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare dictionaries to hold candidate names and the amount of votes that they get
            //candidateVotes contains a list of all the candidates votes
            //topCandidates contains a list of the candidate or candidates with the highest vote count
            Dictionary<string, int> candidateVotes = new Dictionary<string, int>();
            Dictionary<string, int> topCandidates = new Dictionary<string, int>();

            //Declare string to hold the current candidate name and the max votes for any candidate
            string candidateName;
            int max = 0;
            
            //Read the first line of the user input before the loop to get the first input line
            candidateName = Console.ReadLine();

            //Do loop repeats until the input *** is entered
            do

            {
                // If the dictionary candidateVotes contains the current candidate name (input) that we are looking at
                // increase the votes (value) associated with the name by one
                if (candidateVotes.ContainsKey(candidateName))
                {
                    candidateVotes[candidateName]++;
                }
                // If the dictionary does not include the current candidate name then add an new key under that
                // candidate's name and make the value associated equal to one
                else
                {
                    candidateVotes[candidateName] = 1;
                }

                // get the next candidate line.
                candidateName = Console.ReadLine();

               // end the loop if the line we just read was stars
            }
            while (!candidateName.Equals("***")) ;

            //Foreach loop to look at the values associated to all candidates on the dictionary
            //and find the one with the most votes.
            foreach (KeyValuePair<string, int> candidate in candidateVotes)
            {
                // If the votes associated with a candidate are greater than the current max then make that value the max,
                // clear the dictionary of past candidates and store the candidates name in the topCandidates dictionary
                if (candidate.Value > max)
                {
                    topCandidates.Clear();
                    max = candidate.Value;
                    topCandidates[candidate.Key] = candidate.Value;
                }
                //If the votes for a candidate is equal to the max then there is already one with this many votes
                //so we are going to add that candidate in the topCandidates dictionary
                else if (candidate.Value == max)
                {
                    topCandidates[candidate.Key] = candidate.Value;

                }
            }
            // If there is only one entry in the topCandidates dictionary then write the name of that candidate
            if (topCandidates.Count == 1)
            {
               
                // The count is only one, so this loop will always output only one candidate name
                foreach (KeyValuePair<string, int> winner in topCandidates)
                {
                    Console.WriteLine(winner.Key);
                }
             // Else there are more that one, write runoff
            } else { 
                Console.WriteLine("Runoff!");
            }

              
           

        }
    }
}
