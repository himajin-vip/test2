using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 public abstract class Data
{
     protected Key Key;
     protected Value Value;
     public Key GetKey(){
          return Key.Copy();
     }
     public Value GetValue(){
          return  Value.Copy();
     }

     public abstract Data Copy();

     public void Add(Value value){
          Value.Add(value);
     }
     public bool Reduce(Value value){
          return Value.Reduce(value);
     }
     public bool EqualCheckDataType(DataType dataType){
          return Key.EqualCheckDataType(dataType);
     }
}
