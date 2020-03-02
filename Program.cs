using System;
using System.Collections.Generic;

namespace Heist {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Plan a Heist");
            List<Dictionary<string, string>> teamList = new List<Dictionary<string, string>> ();
            int bankDifficulty = 100;
            int allSkillLevel = 0;

            while (true) {

                Dictionary<string, string> teamMember = new Dictionary<string, string> ();
                Console.WriteLine ("Enter team member's name");
                string memberName = Console.ReadLine ();

                if (memberName == "") {
                    break;

                } else {

                    teamMember.Add ("name", memberName);

                    Console.WriteLine ("Enter team skill level");
                    string memberSkill = Console.ReadLine ();
                    teamMember.Add ("skill", memberSkill);

                    Console.WriteLine ("Enter courage level 0.0 - 2.0");
                    string memberCourage = Console.ReadLine ();
                    teamMember.Add ("level", memberCourage);

                    // foreach (KeyValuePair<string, string> member in teamMember) {
                    //     Console.WriteLine ($"{member.Key}: {member.Value}");

                }
                teamList.Add (teamMember);

            }

            foreach (Dictionary<string, string> member in teamList) {
                foreach (KeyValuePair<string, string> pair in member) {
                    if (pair.Key == "skill") {

                        int skillLevel = int.Parse (pair.Value);
                        allSkillLevel += skillLevel;

                    }
                }
            }

            Console.WriteLine (teamList.Count);
            Console.WriteLine (allSkillLevel);

            if (bankDifficulty > allSkillLevel) {
                Console.WriteLine ("You are all dead");
            } else {
                Console.WriteLine ("You may be able to pull this off");
            }

        }
    }
}