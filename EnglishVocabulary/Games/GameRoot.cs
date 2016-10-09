using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVocabulary.Games
{
    internal abstract class GameRoot
    {
        Sozluk<string, WordRoot> _WordList;

        public GameRoot() { }
        public GameRoot(Sozluk<string,WordRoot> GetDictionary)
        {
            _WordList = GetDictionary;
        }

        //  Gets random words from Sozluk
        public WordRoot ReturnRandomWord()
        {

        }

        //  Returns a spesific question
        //  To do this, create a delegate that represents all the types of question methods
        public string[] BuildQuestion(WordRoot Word)
        {

        }


    }
}
