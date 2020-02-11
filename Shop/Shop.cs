using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop
{
    Dictionary<ItemName,int> ItemList = new Dictionary<ItemName,int>();
    Dictionary<string,ShopScene> SceneList = new Dictionary<string, ShopScene>();
    ShopScene ShopScene;
    GameObject ShopWindow;
    
    public Shop(){
        ItemList.Clear();
        SceneList.Clear();
        ShopWindow = GameObject.Find("ShopCanvas").transform.Find("ShopPanel").gameObject;
        ShopWindow.SetActive(true);
    }

    
}
