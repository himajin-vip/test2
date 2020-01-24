using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
  static Dictionary<int,string> ItemList = new Dictionary<int,string>();
  static private bool Setend = false;

    public static void SetItemList(){//Excelとかで読み込めないかな
      if(!Setend){
        ItemList.Add(0,"portion");
        Setend = true;
      }
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
