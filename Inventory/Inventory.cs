﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<int,int> List = new Dictionary<int, int>();

    public void Add(ItemID itemID,ItemPeace itemPeace){
        if(HaveCheck(itemID)){
            List.Add(itemID.GetID(),itemPeace.GetPeace());
        }
        if(!HaveCheck(itemID)){
            List[itemID.GetID()] = itemPeace.GetPeace();
        }
    }
    public void Reduce(ItemID itemID,ItemPeace itemPeace){
        if(HaveCheck(itemID)){
            List[itemID.GetID()] -= itemPeace.GetPeace();
            RemoveItem(itemID);
        }
    }
    public void RemoveItem(ItemID itemID){
        if(List[itemID.GetID()]<=0){
            List.Remove(itemID.GetID());
        }
    }

    public int ReturnPeace(ItemID itemID){
        if(HaveCheck(itemID)){
            return List[itemID.GetID()];
        }
        return 0;        
    }
    public bool HaveCheck(ItemID itemID){
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
