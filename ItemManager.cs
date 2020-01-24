using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
  static Dictionary<int,string> ItemList = new Dictionary<int,string>();

    public static void SetItemList(){
      ItemList.Add(0,"portion");
    }
    public static GameObject returnItemObject(int ItemID){
      return (GameObject)Resources.Load ("prefab/"+ItemList[ItemID]);
    }
    public static void DropItem(int key,float x,float y){
      GameObject obj = (GameObject)Resources.Load ("prefab/"+ItemList[key]);
      GameObject obj2 = Instantiate(obj, new Vector3(x,y,0), Quaternion.identity);
      obj2.GetComponent<IItem>().DropItem();
    }

}
