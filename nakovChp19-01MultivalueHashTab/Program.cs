using System.Collections.Generic;


namespace MultiValue_Dictionary
{
    public class Dictionary_MultiValue<Tkey, TVal> : Dictionary<Tkey, List<TVal>>
    {
        public void Add(Tkey key, TVal val)
        {
            if (!base.ContainsKey(key))
                base.Add(key, new List<TVal>());
            base[key].Add(val);
        }
    }
}