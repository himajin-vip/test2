using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 public class Data
{
     protected Key Key;
     protected Value Value;
     public Data(Key key,Value value){
          Key = key;
          Value = value;
     }
     public Key GetKey(){
          return Key.Copy();
     }
     public Value GetValue(){
          return  Value.Copy();
     }

     public Data Copy(){
          return new Data(Key.Copy(),Value.Copy());
     }

     public void Add(Value value){
          Value.Add(value);
     }
     public bool Reduce(Value value){
          return Value.Reduce(value);
     }
     public bool TypeCheck(Type type){
          if(Key.GetType() == type){
               return true;
          }
          return false;
     }
     public bool EqualCheckDataType(DataType dataType){
          return Key.EqualCheckDataType(dataType);
     }
}
