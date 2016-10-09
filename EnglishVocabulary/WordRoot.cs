using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVocabulary
{
    public enum WordType
    {

    }

    public class WordRoot
    {
        public enum Level {Weak=0,Medium=1,Strong=2 };

        string _EnglishWord;            //  English Word (Key Value)
        string _WordType;               //  Kelime Tipi (Noun, Verb, etc.) 
        string[] _DefinitionsinTurkish; //  Meanings in Turkish
        string[] _DefinitionsinEnglish; //  Meanings in English
        string[] _SampleSentences;      //  SampleSentences in English
        string[] _Synonyms;             //  Eşanlamlı sözcükler
        string[] _Antonyms;             //  Zıt anlamlı sözcükler
        string[] _Hints;                //  Hints
        int _WordPoint;                 //  Kelimenin başarı puanı
        Level _WordLevel;               //  Kelimenin düzeyi

        string[] _WordDefinitation;

        public WordRoot() { }
        public WordRoot(string Word,string Type)
        {
            _EnglishWord = Word;
            _WordType = Type;
            _WordPoint = 0;
            _WordLevel = Level.Weak;

            _WordDefinitation = new string[3];
            _WordDefinitation[0] = _EnglishWord;
            _WordDefinitation[1] = _WordType;
            _WordDefinitation[2] = _WordPoint.ToString();
        }
        public WordRoot(string Word, string Type, string[] DefTurk, string[] DefEng,
                        string[] Samples, string[] Hints)
        {
            _EnglishWord = Word;
            _WordType = Type;
            _WordLevel = Level.Weak;

            _DefinitionsinTurkish = new string[DefTurk.Length];
            DefTurk.CopyTo(_DefinitionsinTurkish, 0);

            _DefinitionsinEnglish = new string[DefEng.Length];
            DefEng.CopyTo(_DefinitionsinEnglish, 0);

            _SampleSentences = new string[Samples.Length];
            Samples.CopyTo(_SampleSentences, 0);

            _Hints = new string[Hints.Length];
            Hints.CopyTo(_Hints, 0);

            _WordPoint = 0;
        }

        //  Word Definitation
        public string[] WordDefination
        {
            get { return _WordDefinitation; }
        }

        public string Word
        {
            get { return _EnglishWord; }
            set { _EnglishWord = value; }
        }

        //  Oyunun kurallarına bağlı olarak seviyeler belirlenir.
        public void SetLevel()
        {
            if (Point < 60)
                _WordLevel = Level.Weak;
            else if (Point < 90)
                _WordLevel = Level.Medium;
            else
                _WordLevel = Level.Strong;
        }

        public Level WordLevel
        {
            get { return _WordLevel; }
        }

        public string Type
        {
            get { return _WordType; }
            set { _WordType = value; }
        }

        public string[] TurkishDef
        {
            get { return _DefinitionsinTurkish; }
        }

        public string[] EnglishDef
        {
            get { return _DefinitionsinEnglish; }
        }

        public string[] Samples
        {
            get { return _SampleSentences; }
        }

        public string[] Synonyms
        {
            get { return _Synonyms; }
        }

        public string[] Antonyms
        {
            get { return _Antonyms; }
        }

        public string[] Hints
        {
            get { return _Hints; }
        }

        public int Point
        {
            get { return _WordPoint; }
            set { _WordPoint = value; }
        }

        public void AddDefTurk(string Defination)
        {
            string[] temp = new string[_DefinitionsinTurkish.Length + 1];
            _DefinitionsinTurkish.CopyTo(temp, 0);
            temp[temp.Length - 1] = Defination;
            _DefinitionsinTurkish = temp;
        }

        public void AddDefEng(string Defination)
        {
            string[] temp = new string[_DefinitionsinEnglish.Length + 1];
            _DefinitionsinEnglish.CopyTo(temp, 0);
            temp[temp.Length - 1] = Defination;
            _DefinitionsinEnglish = temp;
        }

        public void AddSample(string Sample)
        {
            string[] temp = new string[_SampleSentences.Length + 1];
            _SampleSentences.CopyTo(temp, 0);
            temp[temp.Length - 1] = Sample;
            _SampleSentences = temp;
        }

        public void AddSynonym(string Synonym)
        {
            string[] temp = new string[_Synonyms.Length + 1];
            _Synonyms.CopyTo(temp, 0);
            temp[temp.Length - 1] = Synonym;
            _Synonyms = temp;
        }

        public void AddAntonym(string Antonym)
        {
            string[] temp = new string[_Antonyms.Length + 1];
            _Antonyms.CopyTo(temp, 0);
            temp[temp.Length - 1] = Antonym;
            _Antonyms = temp;
        }

        public void AddHint(string Hint)
        {
            string[] temp = new string[_Hints.Length + 1];
            _Hints.CopyTo(temp, 0);
            temp[temp.Length - 1] = Hint;
            _Hints = temp;
        }
    }
}
