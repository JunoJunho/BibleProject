﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleProject.Model
{
    public class MultiKeyDictionary<K1, K2, V>: Dictionary<K1, Dictionary<K2, V>>
    {
        public V this[K1 key1, K2 key2]
        {
            get
            {
                if (!ContainsKey(key1) || !this[key1].ContainsKey(key2))
                    throw new ArgumentOutOfRangeException();
                return base[key1][key2];
            }
            set
            {
                if (!ContainsKey(key1))
                    this[key1] = new Dictionary<K2, V>();
                this[key1][key2] = value;
            }
        }

        public void Add(K1 key1, K2 key2, V value)
        {
            if (!ContainsKey(key1))
                this[key1] = new Dictionary<K2, V>();
            this[key1][key2] = value;
        }

        public bool ContainsKey(K1 key1, K2 key2)
        {
            return base.ContainsKey(key1) && this[key1].ContainsKey(key2);
        }

        public new IEnumerable<V> Values
        {
            get
            {
                return from baseDict in base.Values
                       from baseKey in baseDict.Keys
                       select baseDict[baseKey];
            }
        }
    }

    public class TripleKeyDictionary<K1, K2, K3, V> : Dictionary<K1, MultiKeyDictionary<K2, K3, V>>
    {
        public V this[K1 key1, K2 key2, K3 key3]
        {
            get
            {
                return ContainsKey(key1) ? this[key1][key2, key3] : default(V);
            }
            set
            {
                if (!ContainsKey(key1))
                    this[key1] = new MultiKeyDictionary<K2, K3, V>();
                this[key1][key2, key3] = value;
            }
        }
        public bool ContainsKey(K1 key1, K2 key2, K3 key3)
        {
            return base.ContainsKey(key1) && this[key1].ContainsKey(key2, key3);
        }
        public void Add(K1 key1, K2 key2, K3 key3, V value)
        {
            if (!ContainsKey(key1))
                this[key1] = new MultiKeyDictionary<K2, K3, V>();
            this[key1][key2, key3] = value;
        }
    }
}
