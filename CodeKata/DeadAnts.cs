using System.Linq;

namespace CodeKata
{
    public class DeadAnts
    {
        public int DeadAntCount(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            return GetDeadAntCount(RemoveSurvivingAnts(ants));
        }

        private static int GetDeadAntCount(string deadAnts)
        {
            var headCount = deadAnts.Count(x => x == 'a');
            var bodyCount = deadAnts.Count(x => x == 'n');
            var assCount = deadAnts.Count(x => x == 't');
            var deadAntCount = new[] {headCount, bodyCount, assCount}.Max();
            return deadAntCount;
        }

        private static string RemoveSurvivingAnts(string ants)
        {
            var deadAnts = ants.Replace("ant", "");
            return deadAnts;
        }
    }
}