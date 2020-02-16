using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public interface IDataCounter
{
     void Add(IData IData);
     bool Reduce(Key Key,Value Value);
     Value GetValue(Key Key);
     void Load(List<List<IData>> IDatasList);
     List<List<IData>> GetIDatasList();

}
