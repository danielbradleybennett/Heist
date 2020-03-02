using System;
using System.Collections.Generic;

namespace Heist {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ("Plan a Heist");
            Dictionary<string, string> teamMember = new Dictionary<string, string> ();

            Console.WriteLine ("Enter team member's name");
            string memberName = Console.ReadLine ();
            teamMember.Add ("name", memberName);

            Console.WriteLine ("Enter team skill level");
            string memberSkill = Console.ReadLine ();
            teamMember.Add ("skill", memberSkill);

            Console.WriteLine ("Enter courage level 0.0 - 2.0");
            string memberCourage = Console.ReadLine ();
            teamMember.Add ("level", memberCourage);

            foreach (KeyValuePair<string, string> member in teamMember) {

                Console.WriteLine ($"{member.Key}: {member.Value}");
            }

        }
    }
}