using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public List<int> ItemIDList{get; private set;} = new List<int>();
    public List<int> ItemPeaceList{get; private set;} = new List<int>();

    public void Add(int addItemNo,int addItemPeace){
        bool NewItem = true;
        int count = 0;
        foreach(int ItemID in ItemIDList){
            if( ItemID == addItemNo ){
                NewItem = false;
                break;
            }
            count++;
        }
        if(NewItem){
            ItemIDList.Add(addItemNo);
            ItemPeaceList.Add(addItemPeace);
        }else{
            ItemPeaceList[count] += addItemPeace;
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
