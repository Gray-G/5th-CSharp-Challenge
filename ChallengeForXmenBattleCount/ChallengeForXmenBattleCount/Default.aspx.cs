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

            int minIndex = 0; // Save index position of min number[] value
            int maxIndex = 0; // Save index position of max number[] value

            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex]) // If numbers[i] is greater than previous max ...
                {
                    maxIndex = i; // ... save that index location
                }
                if (numbers[i] < numbers[minIndex]) // If numbers[i] is less than previous min ...
                {
                    minIndex = i; // ... save that index location
                }
            }

            result = $"Most battles belong to: {names[maxIndex]} (Value: {numbers[maxIndex]})" +
                $"<br />Least battles belong to: {names[minIndex]} (Value: {numbers[minIndex]})";

            resultLabel.Text = result;
        }
    }
}