using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Datas
{
        void Add(Data data);
        bool Reduce(Key key,Value value);
        Value GetValue(Key key);
        
        // void Load(List<Data> datalist);
        PublicDatas GetDatas();
}
