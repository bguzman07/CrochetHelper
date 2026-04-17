using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetApp2._0.Models
{
    public class Validation
    {
        /// <summary>
        /// Makes sure pattern has a name and follows the format if adding
        /// </summary>
        /// <param name="Pattern">Pattern to be validated</param>
        /// <returns></returns>
        public static string IsValidPattern(UserPattern Pattern)
        {
            string msg = "";
            UserPattern prevPattern = PatternDB.GetPatternByName(Pattern.Name);
            
            if (prevPattern != null)
            {
                if (Pattern.Name == prevPattern.Name && CrochetHelper.isAdd == true)
                {
                    msg += $"The name {prevPattern.Name} is already in use. Please use a different name.\n\n";
                }
            }
            else if (Pattern.Name == "")
            {
                msg += "Please enter a name for your pattern.\n\n";
            }
            if (Pattern.Pattern == "")
            {
                msg += "Please enter a pattern.\n\n";
            }
            else if (Pattern.Rows.Count == 0 && Pattern.UseRowCounter)
            {
                msg += "Please enter a pattern following the correct format.\n(Start each line with R# so it works with the row counter. Other notes are fine.)\n\n";
            }

            return msg;
        }
    }
}
