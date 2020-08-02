using System.Linq;

namespace CodeKata
{
    public class DeadAntCounter
    {
        public int CalculateDeadAnt(string ants)
        {
            if (string.IsNullOrEmpty(ants))
            {
                return 0;
            }

            var deadAnts = RemoveSurvivingAnts(ants);
            return Max(HeadCount(deadAnts), BodyCount(deadAnts), AssCount(deadAnts));
        }

        private static int Max(int headCount, int bodyCount, int assCount)
        {
            var deadAntCount = new[] { headCount, bodyCount, assCount }.Max();
            return deadAntCount;
        }

        private static int AssCount(string deadAnts)
        {
            var assCount = deadAnts.Count(x => x == 't');
            return assCount;
        }

        private static int BodyCount(string deadAnts)
        {
            var bodyCount = deadAnts.Count(x => x == 'n');
            return bodyCount;
        }

        private static int HeadCount(string deadAnts)
        {
            var headCount = deadAnts.Count(x => x == 'a');
            return headCount;
        }

        private static string RemoveSurvivingAnts(string ants)
        {
            var deadAnts = ants.Replace("ant", "");
            return deadAnts;
        }
    }
}