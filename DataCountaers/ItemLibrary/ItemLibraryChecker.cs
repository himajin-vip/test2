
using System.Collections.Generic;
using System;
public class ItemLibraryChecker:DataChecker
{
    public ItemLibraryChecker(){
        foreach (DataType_ItemLibrary Value in Enum.GetValues(typeof(DataType_ItemLibrary))){
            DataTypes.Add(new DataType(Value.ToString()));
        }
    }

}