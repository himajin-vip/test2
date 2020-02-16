using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDatas
{
        void Add(IData data);
        bool Reduce(Key key,Value value);
        Value GetValue(Key key);
        void Load(List<IData> datalist);
        List<IData> GetIDatas();
}
