using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 public abstract class IData
{
     protected Key Key;
     protected Value Value;
    public IData(){
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
          return new FirstintClassConvertor().Toint(Key);
     }
     public int GetintValue(){
          return new FirstintClassConvertor().Toint(Value);
     }
     public abstract IData Copy();

     public void Add(Value value){
          Value.Add(value);
     }
     public void Reduce(Value value){
          Value.Add(value);
     }
     public bool EqualCheckDataType(IDataType dataType){
          return Key.EqualCheckDataType(dataType);
     }
     public bool NullCheck(){
          if(Key.NullCheck()||Value.NullCheck()){
               return true;
          }
          return false;
     }
}
