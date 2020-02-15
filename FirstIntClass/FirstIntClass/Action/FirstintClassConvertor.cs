using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstintClassConvertor
{
    public int Toint(FirstIntClass firstint){
        return firstint.GetValue();
    }
    public List<int> Toints(List<FirstIntClass> firstints){
        List<int> ints = new List<int>();
        for(int i = 0; i<firstints.Count;i++){
            int Int = Toint(firstints[i]);
            ints.Add(Int);
        }
        return ints;
    }
    public ItemID ToItemID(FirstIntClass firstint){
        return new ItemID(firstint.GetValue());
    }
    public List<ItemID> ToItemIDs(List<FirstIntClass> firstints){
        List<ItemID> itemIDs = new List<ItemID>();
        for(int i = 0; i<firstints.Count;i++){
            ItemID itemID = ToItemID(firstints[i]);
            itemIDs.Add(itemID);
        }
        return itemIDs;
    }
    public ItemPeace ToItemPeace(FirstIntClass firstint){
        return new ItemPeace(firstint.GetValue());
    }
    public List<ItemPeace> ToItemPeaces(List<FirstIntClass> firstints){
        List<ItemPeace> peaces = new List<ItemPeace>();
        for(int i = 0; i<peaces.Count;i++){
            ItemPeace itemPeace = ToItemPeace(peaces[i]);
            peaces.Add(itemPeace);
        }
        return peaces;
    }
    public string ToString(FirstIntClass firstint){
        string text;
        int value = firstint.GetValue();
        text = value.ToString();
        return text;
    }
}
