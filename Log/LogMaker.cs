using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMaker
{
    private  LogCanvas logCanvas;
    public void GetComponent(){
        logCanvas = GameObject.Find("LogCanvas").GetComponent<LogCanvas>();
        logCanvas.SetUp();
    }
    public void DamageLog(string Name,int damage){
        string newlog = (Name+"は"+damage+"のダメージを受けた");
        logCanvas.MakeLog(newlog);
    }
    public void GetExpLog(string Name ,int Exp){
        string newlog = (Name+"は"+Exp+"の経験値を手に入れた");
        logCanvas.MakeLog(newlog);
    }
    public void LvUpLog(string Name){
        string newlog = (Name+"はLVが上がった");
        new PlayAudio().Play(AudioList.LVUP);
        logCanvas.MakeLog(newlog);
    }
    // public void ItemGetLog(string Name ,ItemID itemID){
    //     // // ItemName itemName = new GetItemName().Get(itemID);
    //     // string newlog = (Name+"は"+itemName.GetValue()+"を手に入れた");
    //     // logCanvas.MakeLog(newlog);
    // }
    public void RecoveryHpLog(string Name,int recovery){
        string newlog = (Name+"はHPを"+recovery+"回復した");
        logCanvas.MakeLog(newlog);
    }
    // public void UseItemLog(string Name,ItemDataValue itemName){
    // //     string newlog = (Name+"は"+ItemDataValue+"を使った");
    // // logCanvas.MakeLog(newlog);
    // }
}
