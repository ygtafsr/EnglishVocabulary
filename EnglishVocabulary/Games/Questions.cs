using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVocabulary.Games
{
    public class Questions
    {
        enum QuestionType { WriteTurkishMean=0,WriteEnglishMean=1,MultipleChoiseTurkish=2
                            ,MultipleChoiseEnglish=3,FillBlanks=4};

        public Questions() { }
        
        //  Question Type: English Word --> Turkish Word
        public Dictionary<string,string[]> QuestionType_1<K,V>(WordRoot Word)
        {
            Dictionary<string, string[]> QuestionList = new Dictionary<string, string[]>();

            string[] WordDefination = new string[3];
            WordDefination[0] = Word.Word;
            WordDefination[1] = Word.Type;
            WordDefination[2] = (Word.Point).ToString();

            QuestionList.Add("Question", WordDefination);           //  Question (English Word)
            QuestionList.Add("Answer", Word.Turkish);               //  Turkish Word (Answer)
            QuestionList.Add("English Hints", Word.Hints);          //  English Hints (Synonyms etc.)
            QuestionList.Add("English Sentences", Word.Samples);    //  Example Engslih Sentences

            return QuestionList;
        }

        //  Question Type: Turkish Word --> English Word
        public Dictionary<string, string[]> QuestionType_1<K, V>(WordRoot Word)
        {
            Dictionary<string, string[]> QuestionList = new Dictionary<string, string[]>();

            string[] WordDefination = new string[3];
            WordDefination[0] = Word.Turkish;       //      DEFINATIONS'LARI WORDROOT SINIFINDA TANIMLA
                                                    //      DEFINATIONS'LARIN NASIL OLACAĞINA KESİN OLARAK KARAR VER.
            WordDefination[1] = Word.Type;
            WordDefination[2] = (Word.Point).ToString();

            QuestionList.Add("Question", WordDefination);           //  Question (English Word)
            QuestionList.Add("Answer", Word.English);               //  Turkish Word (Answer)
            QuestionList.Add("English Hints", Word.Hints);          //  English Hints (Synonyms etc.)
            QuestionList.Add("English Sentences", Word.Samples);    //  Example Engslih Sentences
        }
    }
}
