
using System.Collections.Generic;
using System;
public class CharactorDataCheker:DataChecker
{
    public CharactorDataCheker(){
        foreach (DataType_Charactor Value in Enum.GetValues(typeof(DataType_Charactor))){
            DataTypes.Add(new DataType(Value.ToString()));
        }
    }

}