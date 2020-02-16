using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public interface IDatasList
{
     void Add(IData idata);
     bool Reduce(Key key,Value value);
     Value GetValue(Key Key);
     void Load(List<List<IData>> IDatas);
     List<List<IData>> GetIDatasList();

}
