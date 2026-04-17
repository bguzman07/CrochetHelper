using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CrochetApp2._0.Models
{
    public class UserPattern
    {
        public string Name = "";
        public string Pattern = "";
        public List<string> Rows = new List<string>();
        public int RowIndex = 0;
        public DateTime DateUpdated;
        public bool UseRowCounter;

        /// <summary>
        /// Creates new pattern
        /// </summary>
        /// <param name="name">Name of the pattern</param>
        /// <param name="pattern">Pattern text</param>
        public UserPattern(string name, string pattern, bool useRowCounter)
        {
            this.Name = name;
            Pattern = pattern;
            Rows = SplitRows(pattern);
            DateUpdated = DateTime.Now;
            UseRowCounter = useRowCounter;
        }

        /// <summary>
        /// Creates pattern from all necessary variables
        /// </summary>
        /// <param name="name">Name of the pattern</param>
        /// <param name="pattern">Pattern text</param>
        /// <param name="rowIndex">Current row index of pattern</param>
        /// <param name="dateUpdated">Last date updated</param>
        public UserPattern(string name, string pattern, int rowIndex, DateTime dateUpdated, bool useRowCounter)
        {
            this.Name = name;
            Pattern = pattern;
            RowIndex = rowIndex;
            DateUpdated = dateUpdated;
            Rows = SplitRows(pattern);
            UseRowCounter = useRowCounter;
        }

        /// <summary>
        /// Splits the pattern into a list of rows
        /// </summary>
        /// <param name="pattern">Pattern text to be split</param>
        /// <returns>List of row strings that follow Row Counter format</returns>
        public static List<string> SplitRows(string pattern)
        {
            string[] rows = pattern.Split("\n");
            List<string> result = new List<string>();

            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i].Length >= 2)
                {
                    if (rows[i][0].ToString().ToLower() == "r" && Char.IsDigit(rows[i][1]))
                    {
                        result.Add(rows[i]);
                    }
                }
            }

            return result;
        }
    }
}
