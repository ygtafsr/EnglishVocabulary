using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVocabulary
{
    public class Sozluk<K,V> where V :WordRoot
    {
        Dictionary<K, V> WeakDict;
        Dictionary<K, V> MediumDict;
        Dictionary<K, V> StrongDict;

        public Sozluk()
        {
            WeakDict = new Dictionary<K, V>();
            MediumDict = new Dictionary<K, V>();
            StrongDict = new Dictionary<K, V>(); 
        }

        public void Transfer(WordRoot Word, Dictionary<K, V> WordList)
        {
            //  Word, bulunduğu WordList'ten silinmeli ve uygun WordList'e akatarılmalı.
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
