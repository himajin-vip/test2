using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataSetUper
{
    ItemLibrary itemLibrary;
    ItemDataSetUper(ItemLibrary itemlibrary){
        itemLibrary = itemlibrary;
    }
    public void SetUp(){
        ItemData itemData;
        itemData = new ItemDataMaker().MakeName(1,"ポーション",ItemLibrarys.Name);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeName(2,"ハイポーション",ItemLibrarys.Name);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeName(3,"エリクサー",ItemLibrarys.Name);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeInfo(1,"回復するよ",ItemLibrarys.Info);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeInfo(2,"沢山回復するよ！",ItemLibrarys.Info);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeInfo(3,"全部回復するよ！",ItemLibrarys.Info);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakePrice(1,10,ItemLibrarys.Price);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakePrice(2,30,ItemLibrarys.Price);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakePrice(3,1000,ItemLibrarys.Price);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeType(1,ItemType.Use,ItemLibrarys.Price);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeType(1,ItemType.Use,ItemLibrarys.Price);
        itemLibrary.Add(itemData);
        itemData = new ItemDataMaker().MakeType(1,ItemType.Use,ItemLibrarys.Price);
    }

}
