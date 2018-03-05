using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCodeParser
{
    /// <summary>
    /// Class used to splitter a text in list of words
    /// > List<string> SplitText(string text)
    /// > AddSeparator(string strSeparator)
    /// </summary>
    public class csWordSplitter
    {
        #region Private

        /// <summary>
        /// List of separator used to split the word
        /// </summary>
        List<string> separatorList;

        /// <summary>
        /// List of word after split process
        /// </summary>
        List<string> wordList;

        #endregion

        #region Public

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textToSplit"></param>
        /// <returns></returns>
        public List<string> SplitText(string textToSplit)
        {
            if (textToSplit != "")
            {
                wordList = new List<string>();
            }

            return (wordList);
        }

        /// <summary>
        /// Update the separator list
        /// </summary>
        /// <param name="separator"></param>
        public void AddSeparator(string separator)
        {
            separatorList.Add(separator);
        }

        #endregion
    }
}
