using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public interface DatasList
{
     void Add(Data Data);
     bool Reduce(Key key,Value value);
     Value GetValue(Key Key);
     void Load(List<List<Data>> Datas);
     List<List<Data>> GetDatasList();

}
