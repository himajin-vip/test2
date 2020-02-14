using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<int,int> List = new Dictionary<int, int>();

    public void Add(ItemBag itembag){
        ItemID itemID = itembag.GetID();
        ItemPeace itemPeace = itembag.GetPeace();
        if(HasCheck(itemID)){
            List.Add(itemID.GetValue(),itemPeace.GetValue());
        }
        if(!HasCheck(itemID)){
            List[itemID.GetValue()] = itemPeace.GetValue();
        }
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        if(HasCheck(itemID)){
            List[itemID.GetValue()] -= itemPeace.GetValue();
            RemoveItem(itemID);
        }
    }
    public void RemoveItem(ItemID itemID){
        if(List[itemID.GetValue()]<=0){
            List.Remove(itemID.GetValue());
        }
    }

    public ItemPeace GetPeace(ItemID itemID){
        if(HasCheck(itemID)){
            return new ItemPeace(List[itemID.GetValue()]);
        }
        return new ItemPeace(0);        
    }
    public bool HasCheck(ItemID itemID){
        List<int> Idlist = new List<int>(List.Keys);
        return Idlist.Contains(itemID.GetValue());
    }
    public void Load(List<int> itemIDList, List<int> itemPeaceList){
        for(int i = 0;i<itemIDList.Count;i++){
            List.Add(itemIDList[i],itemPeaceList[i]);
        }
    }
    public List<int> GetIdList(){
        return new List<int>(List.Keys);
    }
    public List<int> GetPeaceList(){
        return new List<int>(List.Values);
    }
}
