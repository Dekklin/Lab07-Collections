using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections
{
    public class Deck<T> : IEnumerable
    {
        T[] deck = new T[53];

        int count;

        public bool Add(T card)
        {
            if(count == deck.Length)
            {
                Array.Resize(ref deck, deck.Length * 2);
            }
            deck[count++] = card;
            return true;
        }

        public bool Remove(T item)
        {
            for(int i = 0; i < count; i++)
            {
                if(item.Equals(deck[i]))
                {
                    deck[i] = default;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public bool Shuffle()
        {
            try
            {
                int n = deck.Length;
                Random rnd = new Random();
                while (n > 1)
                {
                    n--;
                    int k = rnd.Next(n + 1);
                    T newPos = deck[k];
                    deck[k] = deck[n];
                    deck[n] = newPos;
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return deck[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
