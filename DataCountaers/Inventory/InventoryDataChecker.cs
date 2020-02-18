
using System.Collections.Generic;
using System;
public class InvenrtoryDataChecker:DataChecker
{
    public InvenrtoryDataChecker(){
        foreach (DataType_Inventory Value in Enum.GetValues(typeof(DataType_Inventory))){
            DataTypes.Add(new DataType(Value.ToString()));
        }
    }

}