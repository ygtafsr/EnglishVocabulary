using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVocabulary
{
    public class Sozluk
    {
        WordList<WordRoot> WeakDict;
        WordList<WordRoot> MediumDict;
        WordList<WordRoot> StrongDict;

        public Sozluk()
        {
            WeakDict = new WordList<WordRoot>();
        }

        public void Transfer(WordRoot Word, WordList<WordRoot> WordList)
        {
            //  Word, bulunduğu WordList'ten silinmeli ve hedef WordList'e akatarılmalı.
            if(Word.WordLevel)
        }

        public void IncreasePoint(WordRoot Word,int Point)
        {
            Word.Point += Point;
            Word.SetLevel();
        }

        public void DecreasePoint(WordRoot Word, int Point)
        {
            Word.Point -= Point;
            Word.SetLevel();
        }

        //  Sözlükteki toplam eleman sayısı
        public int Total
        {
            get
            {
                int Toplam = WeakDict.Count + MediumDict.Count + StrongDict.Count;
                return Toplam;
            }
        }

        //  WeakDict'teki toplam eleman sayısı
        public int WeaksCount
        {
            get
            {
                return WeakDict.Count;
            }
        }

        //  MediumDict'teki toplam eleman sayısı
        public int MediumsCount
        {
            get
            {
                return MediumDict.Count;
            }
        }

        //  StrongDict'teki toplam eleman sayısı
        public int StrongsCount
        {
            get
            {
                return StrongDict.Count;
            }
        }


    }
}
