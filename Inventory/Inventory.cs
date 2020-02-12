using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<int,int> List = new Dictionary<int, int>();

    public void Add(int addItemNo,int addItemPeace){
        if(HaveCheck(addItemNo)){
            List.Add(addItemNo,addItemPeace);
        }
        if(!HaveCheck(addItemNo)){
            List[addItemNo] = addItemPeace;
        }
    }
    public void Reduce(int reduceItemNo,int reduceItemPeace){
        if(HaveCheck(reduceItemNo)){
            List[reduceItemNo] -= reduceItemPeace;
            RemoveItem(reduceItemNo);
        }
    }
    public void RemoveItem(int itemid){
        if(List[itemid]<=0){
            List.Remove(itemid);
        }
    }

    public int ReturnPeace(int ItemID){
        if(HaveCheck(ItemID)){
            return List[ItemID];
        }
        return 0;        
    }
    public bool HaveCheck(int ItemID){
        List<int> Idlist = new List<int>(List.Keys);
        return Idlist.Contains(ItemID);
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
