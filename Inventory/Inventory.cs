using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Dictionary<int,int> List = new Dictionary<int, int>();

    public void Add(int addItemNo,int addItemPeace){
        List<int> Idlist = new List<int>(List.Keys);
        bool NewItem = true;
        NewItem = Idlist.Contains(addItemNo);
   
        if(NewItem){
            List.Add(addItemNo,addItemPeace);
        }
        if(!NewItem){
            List[addItemNo] = addItemPeace;
        }

    }

    public void Reduce(int reduceItemNo,int reduceItemPeace){
        List<int> Idlist = new List<int>(List.Keys);
        bool haveItem = Idlist.Contains(reduceItemNo);
        if(haveItem){
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
         for(int i = 0;i<ItemIDList.Count;i++){
            if(ItemIDList[i] == ItemID){
                return ItemPeaceList[i];
            }
        } 
        return 0;        
    }
    public void Load(List<int> itemIDList, List<int> itemPeaceList){
        ItemIDList = new List<int>(itemIDList);
        ItemPeaceList = new List<int>(itemPeaceList);
    }
}
