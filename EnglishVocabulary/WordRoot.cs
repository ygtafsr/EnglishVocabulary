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

        string _Word;    // English Word (Key Value)
        string _Type;    // Kelime Tipi (Noun, Verb, etc.) 

        string[] _DefinationsinTurkish;   //  Meanings in Turkish
        string[] _DefinationsinEnglish;    //  Meanings in English

        string[] _SampleSentences;   // SampleSentences
        string[] _Hints;    //  Hints

        int _WordPoint; //  Kelimenin başarı puanı
        Level _WordLevel;  //  Kelimenin düzeyi

        public WordRoot() { }
        public WordRoot(string Word)
        {
            _Word = Word;
            _WordPoint = 0;
            _WordLevel = Level.Weak;
        }
        public WordRoot(string Word, string Type, string[] DefTurk, string[] DefEng,
                        string[] Samples, string[] Hints)
        {
            _Word = Word;
            _Type = Type;
            _WordLevel = Level.Weak;

            _DefinationsinTurkish = new string[DefTurk.Length];
            DefTurk.CopyTo(_DefinationsinTurkish, 0);

            _DefinationsinEnglish = new string[DefEng.Length];
            DefEng.CopyTo(_DefinationsinEnglish, 0);

            _SampleSentences = new string[Samples.Length];
            Samples.CopyTo(_SampleSentences, 0);

            _Hints = new string[Hints.Length];
            Hints.CopyTo(_Hints, 0);

            _WordPoint = 0;
        }

        public string Word
        {
            get { return _Word; }
            set { _Word = value; }
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
            get
            {
                return _WordLevel;
            }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string[] Turkish
        {
            get { return _DefinationsinTurkish; }
            //set { _DefinationsinTurkish = value; }
        }

        public string[] English
        {
            get { return _DefinationsinEnglish; }
            //set { _DefinationsinEnglish = value; }
        }

        public string[] Samples
        {
            get { return _SampleSentences; }
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
            string[] temp = new string[_DefinationsinTurkish.Length + 1];
            _DefinationsinTurkish.CopyTo(temp, 0);
            temp[temp.Length - 1] = Defination;
            _DefinationsinTurkish = temp;
        }

        public void AddDefEng(string Defination)
        {
            string[] temp = new string[_DefinationsinEnglish.Length + 1];
            _DefinationsinEnglish.CopyTo(temp, 0);
            temp[temp.Length - 1] = Defination;
            _DefinationsinEnglish = temp;
        }

        public void AddSample(string Sample)
        {
            string[] temp = new string[_SampleSentences.Length + 1];
            _SampleSentences.CopyTo(temp, 0);
            temp[temp.Length - 1] = Sample;
            _SampleSentences = temp;
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
