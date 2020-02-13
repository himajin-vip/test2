using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<int,int> List = new Dictionary<int, int>();

    public void Add(ItemID itemID,ItemPeace itemPeace){
        if(HasCheck(itemID)){
            List.Add(itemID.GetID(),itemPeace.GetValue());
        }
        if(!HasCheck(itemID)){
            List[itemID.GetID()] = itemPeace.GetValue();
        }
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        if(HasCheck(itemID)){
            List[itemID.GetID()] -= itemPeace.GetValue();
            RemoveItem(itemID);
        }
    }
    public void RemoveItem(ItemID itemID){
        if(List[itemID.GetID()]<=0){
            List.Remove(itemID.GetID());
        }
    }

    public ItemPeace GetPeace(ItemID itemID){
        if(HasCheck(itemID)){
            return new ItemPeace(List[itemID.GetID()]);
        }
        return new ItemPeace(0);        
    }
    public bool HasCheck(ItemID itemID){
        List<int> Idlist = new List<int>(List.Keys);
        return Idlist.Contains(itemID.GetID());
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
