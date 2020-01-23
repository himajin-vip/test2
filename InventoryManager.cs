using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
  static bool NewItem = true;
  static Dictionary<int,int> Inventory = new Dictionary<int,int>();
    // Start is called before the first frame update
    void Start()
    {
      Inventory.Add (0, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    static public void ItemGet(int ID){
      List<int> keyList = new List<int>(Inventory.Keys);
      foreach(int key in keyList) {
        if(key == ID){
          Inventory[key]++;
          NewItem = false;
          Debug.Log("アイテムをふやしました。数は"+Inventory[key]+"個です。");
        }
      }
      if(NewItem){
        Inventory.Add (ID, 1);
        Debug.Log("アイテムを新規追加しました。数は1個です。");
        NewItem = true;
      }
    }
    static public int ReturnPieces(int key){
      return Inventory[key];
    }
    static public void ItemReduce(int key){
      Inventory[key]--;
    }
}
