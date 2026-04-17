using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrochetApp2._0.Models
{
    public class PatternDB
    {
        /// <summary>
        /// Gets the file path where the patterns.json file is stored
        /// </summary>
        /// <returns>patterns.json file path</returns>
        private static string GetPatternsFilePath()
        {
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CrochetApp2.0");
            Directory.CreateDirectory(folder);
            return Path.Combine(folder, "patterns.json");
        }

        /// <summary>
        /// Takes a list of patterns and writes them to the binary file
        /// </summary>
        /// <param name="patterns">List of UserPatterns to be saved</param>
        public static void SavePatterns(List<UserPattern> patterns)
        {
            string path = GetPatternsFilePath();
            try
            {
                BinaryWriter binaryOut = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

                foreach (UserPattern pattern in patterns)
                {
                    binaryOut.Write(pattern.Name);
                    binaryOut.Write(pattern.Pattern);
                    binaryOut.Write(pattern.RowIndex);
                    binaryOut.Write(pattern.DateUpdated.ToString());
                    binaryOut.Write(pattern.UseRowCounter);
                }
                binaryOut.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save patterns to '{path}': {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reads the binary file and returns a list of all saved patterns
        /// </summary>
        /// <returns>A list of UserPattern objects</returns>
        public static List<UserPattern> GetPatterns()
        {
            string path = GetPatternsFilePath();
            List<UserPattern> patterns = new List<UserPattern>();

            if (!File.Exists(path))
            {
                return patterns;
            }

            try
            {
                BinaryReader binaryIn = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

                while (binaryIn.PeekChar() != -1)
                {
                    UserPattern pattern = new UserPattern(
                        binaryIn.ReadString(),
                        binaryIn.ReadString(),
                        binaryIn.ReadInt32(),
                        DateTime.Parse(binaryIn.ReadString()),
                        binaryIn.ReadBoolean()
                        );
                    patterns.Add(pattern);
                }

                binaryIn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to read patterns from '{path}': {ex.Message}", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return patterns;
        }

        /// <summary>
        /// Looks through all saved patterns and returns either null or first pattern with same name
        /// </summary>
        /// <param name="name">The name that is searched</param>
        /// <returns>A UserPattern object</returns>
        public static UserPattern GetPatternByName(string name)
        {
            List<UserPattern> patterns = GetPatterns();

            if (patterns == new List<UserPattern>())
            {
                return null;
            }
            else
            {
                var pattern = patterns.FirstOrDefault(p => p.Name == name);
                if (pattern != null)
                    return pattern; 
                else
                    return null; 
            }
        }
    }
}
