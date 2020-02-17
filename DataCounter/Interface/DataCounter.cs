using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public interface DataCounter
{
     void Add(Data Data);
     bool Reduce(Key Key,Value Value);
     Value GetValue(Key Key);
     // void Load(List<List<Data>> DatasList);
     PublicDatasList GetDatasList();

}
