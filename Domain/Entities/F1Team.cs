using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class F1Team
    {
        public Guid Id { get; set; }
        public string OfficialTeamName { get; set; }
        public string TeamColor { get; set; }
        public string TeamPrinciple { get; set; }
        public string[] TeamDrivers { get; set; }
        public F1Team() { }
        public F1Team(string officialTeamName, string teamColor, string teamPrinciple, string[] teamDrivers)
        {
            OfficialTeamName = officialTeamName;
            TeamColor = teamColor;
            TeamPrinciple = teamPrinciple;
            TeamDrivers = teamDrivers;
        }
        public static F1Team create(string officialTeamName, string teamColor, string teamPrinciple, string[] teamDrivers)
        {
            var F1Team = new F1Team(officialTeamName, teamColor, teamPrinciple, teamDrivers);
            F1Team.Id =  Guid.NewGuid();
            return F1Team;
        }



    }
}
