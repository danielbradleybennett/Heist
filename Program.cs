using System;
using System.Collections.Generic;

namespace Heist {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Plan a Heist");
            Console.Write ("What is the banks difficulty level (1-100)? ");
            int bankDifficulty = int.Parse (Console.ReadLine ());
            List<Dictionary<string, string>> teamList = new List<Dictionary<string, string>> ();

            int allSkillLevel = 0;

            while (true) {

                Dictionary<string, string> teamMember = new Dictionary<string, string> ();
                Console.Write ("Enter team member's name? ");
                string memberName = Console.ReadLine ();
                teamMember.Add ("name", memberName);

                if (memberName == "") {
                    break;

                } else {

                    Console.Write ("Enter team skill level? ");
                    string memberSkill = Console.ReadLine ();
                    teamMember.Add ("skill", memberSkill);

                    Console.Write ("Enter courage level 0.0 - 2.0? ");
                    string memberCourage = Console.ReadLine ();
                    teamMember.Add ("level", memberCourage);

                }
                Console.Clear ();

                teamList.Add (teamMember);
                Console.WriteLine ($"team has {teamList.Count} members ");

            }

            // sum of team members team

            foreach (Dictionary<string, string> member in teamList) {
                foreach (KeyValuePair<string, string> pair in member) {
                    if (pair.Key == "skill") {

                        int skillLevel = int.Parse (pair.Value);
                        allSkillLevel += skillLevel;

                    }
                }
            }

            Console.Write ("How many times should we run simulation? ");
            int timesToRepeat = int.Parse (Console.ReadLine ());

            int success = 0;
            int failures = 0;
            for (int i = 0; i < timesToRepeat; i++) {

                Random randy = new Random ();
                int luckValue = randy.Next (-10, 11);

                bankDifficulty += luckValue;

                Console.WriteLine ($"Bank Difficulty: {bankDifficulty}");
                Console.WriteLine ($"Team Skill Level: {allSkillLevel}");

                if (bankDifficulty > allSkillLevel) {
                    Console.WriteLine ("You are all dead");
                    failures++;
                } else

                {
                    Console.WriteLine ("You may be able to pull this off");
                    success++;
                }
                Console.WriteLine ("-------------------------------");
            }
            Console.WriteLine ($"{success} {failures}");

        }
    }
}