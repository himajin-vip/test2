using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ItemManager
{
  private static Dictionary<int,string> ItemList = new Dictionary<int,string>();
  private static bool Setend = false;

    public static void SetUp(){//Excelとかで読み込めないかな
      if(!Setend){
        ItemList.Add(0,"portion");
        ItemList.Add(1,"IronSword");
        Setend = true;
      }
    }
    public static GameObject returnItemObject(int ItemID){
      return (GameObject)Resources.Load ("prefab/"+ItemList[ItemID]);
    }
    public static void DropItem(int key,float x,float y){
      GameObject obj = (GameObject)Resources.Load ("prefab/"+ItemList[key]);
      GameObject obj2 = GameManager.Instantiate(obj, new Vector3(x,y,0), Quaternion.identity);
      obj2.GetComponent<IItem>().DropItem();
    }

}
