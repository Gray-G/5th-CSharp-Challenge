using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int minBattles = 999; // To keep track of min battles
            int maxBattles = 0; // To keep track of max battles
            int minIndex = 0; // To keep track of respective index for later retrieval
            int maxIndex = 0; // To keep track of respective index for later retrieval

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > maxBattles)
                {
                    maxBattles = numbers[i];
                    maxIndex = i;
                }
                if (numbers[i] < minBattles)
                {
                    minBattles = numbers[i];
                    minIndex = i;
                }
            }

            result = $"Most battles belong to: {names[maxIndex]} (Value: {numbers[maxIndex]})" +
                $"<br />Least battles belong to: {names[minIndex]} (Value: {numbers[minIndex]})";

            resultLabel.Text = result;
        }
    }
}