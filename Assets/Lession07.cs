using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

namespace ZZBase.Lession07
{
    public sealed class Lession07
    {
        public void Task02()
        {
            string s = "В прошлом году был приличный март и несколько сильных осенних месяцев.";
            char ch = 'о';
            Debug.Log(s.CharCount(ch));
        }

        private void DebugLogDictionary<T>(IEnumerable<KeyValuePair<T, int>> dictionary)
        {
            foreach (KeyValuePair<T, int> keyValuePair in dictionary)
            {
                Debug.Log($"value {keyValuePair.Key} repeats {keyValuePair.Value} times");
            }
        }

        private List<int> RandomList(int count, int maxInt)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                result.Add(UnityEngine.Random.Range(0, maxInt));
            }
            return result;
        }

        public SortedDictionary<int, int> SortedFrequencyArrayInt(List<int> list)
        {
            SortedDictionary<int, int> dictionary = new SortedDictionary<int, int>();
            foreach (int element in list)
            {
                if (dictionary.ContainsKey(element))
                {
                    dictionary[element]++;
                }
                else
                {
                    dictionary[element] = 1;
                }
            }

            return dictionary;
        }

        public SortedDictionary<T, int> SortedFrequencyArray<T>(List<T> list)
        {
            SortedDictionary<T, int> dictionary = new SortedDictionary<T, int>();

            foreach (T element in list)
            {
                if (dictionary.ContainsKey(element))
                {
                    dictionary[element]++;
                }
                else
                {
                    dictionary[element] = 1;
                }
            }

            return dictionary;
        }

        public Dictionary<T, int> SortedFrequencyArrayLinq<T>(List<T> list)
        {
            Dictionary<T, int> dictionary = list.GroupBy(element => element).OrderBy(g => g.Key).ToDictionary(g => g.Key, g => g.Count());

            return dictionary;

        }

        public Dictionary<T, int> SortedFrequencyArrayLinqDelegate<T>(List<T> list)
        {
            Dictionary<T, int> dictionary = list.GroupBy(element => element).OrderBy(delegate (IGrouping<T,T> g) { return g.Key; }).ToDictionary(g => g.Key, g => g.Count());

            return dictionary;

        }

        public Dictionary<T, int> SortedFrequencyArrayLinqDelegateParam<T>(List<T> list, Func<IGrouping<T, T>, T> delegat)
        {
            Dictionary<T, int> dictionary = list.GroupBy(element => element).OrderBy(delegat).ToDictionary(g => g.Key, g => g.Count());

            return dictionary;

        }

        public void Task03a()
        {
            List<int> list = RandomList(100, 3);

            SortedDictionary<int, int> dictionary = SortedFrequencyArrayInt(list);

            DebugLogDictionary<int>(dictionary);
        }

        public void Task03b()
        {
            List<int> list = RandomList(100, 3);
            DebugLogDictionary<int>(SortedFrequencyArray<int>(list));
        }

        public void Task03c()
        {
            List<int> list = RandomList(100, 3);
            DebugLogDictionary<int>(SortedFrequencyArrayLinq<int>(list));
        }
    }
}
