using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 public abstract class Data
{
     protected Key Key;
     protected Value Value;
    public Data(){
        Key = new Key(0);
        Value = new Value(0);
    }
     public Key GetKey(){
          return Key.Copy();
     }
     public Value GetValue(){
          return  Value.Copy();
     }
     public int GetintKey(){
          return new IntClassConvertor().Toint(Key);
     }
     public int GetintValue(){
          return new IntClassConvertor().Toint(Value);
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
     public bool NullCheck(){
          if(Key.NullCheck()||Value.NullCheck()){
               return true;
          }
          return false;
     }
}
