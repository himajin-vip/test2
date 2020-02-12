using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<int> ItemIDList{get; private set;} = new List<int>();
    public List<int> ItemPeaceList{get; private set;} = new List<int>();
    Dictionary<int,int> List = new Dictionary<int, int>();

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
        for(int i = 0;i<ItemIDList.Count;i++){
            if(ItemIDList[i] == reduceItemNo){
                ItemPeaceList[i] -= reduceItemPeace;
                if(ItemPeaceList[i] <=0 ){
                    ItemIDList.Remove(i);
                    ItemPeaceList.Remove(i);
                }
            }
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
