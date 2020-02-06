using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class LogManager
{
  private static Dictionary<int,Text> LogList = new Dictionary<int,Text>();
  private static int LogCount;
  public static void SetUp(){
    LogList.Clear();
    Text text0 = GameObject.Find("LogText0").GetComponent<Text>();
    LogList.Add(0,text0);
    Text text1 = GameObject.Find("LogText1").GetComponent<Text>();
    LogList.Add(1,text1);
    Text text2 = GameObject.Find("LogText2").GetComponent<Text>();
    LogList.Add(2,text2);
    Text text3 = GameObject.Find("LogText3").GetComponent<Text>();
    LogList.Add(3,text3);
    Text text4 = GameObject.Find("LogText4").GetComponent<Text>();
    LogList.Add(4,text4);
    Text text5 = GameObject.Find("LogText5").GetComponent<Text>();
    LogList.Add(5,text5);
    Text text6 = GameObject.Find("LogText6").GetComponent<Text>();
    LogList.Add(6,text6);
    Text text7 = GameObject.Find("LogText7").GetComponent<Text>();
    LogList.Add(7,text7);
    LogRefresh();
  }
  public static void LogRefresh(){
    for(int i = 0;i<=7;i++){
      LogList[i].text="";
    }
    LogCount = 0;
  }
  public static void MakeLog(string NewText){
    if(LogCount <= 7){
      LogList[LogCount].text = NewText;
      LogCount++;
    }else{
      int i=0;
      while(i<7){
        LogList[i].text = LogList[i+1].text;
        i++;
      }
      LogList[7].text = NewText;
    }
  }
  public static void MakeDamageLog(string Name,int damage){
    string newlog = (Name+"は"+damage+"のダメージを受けた");
    MakeLog(newlog);
  }
  public static void RecoveryHpLog(string Name,int recovery){
    string newlog = (Name+"はHPを"+recovery+"回復した");
    MakeLog(newlog);
  }
  public static void MakeItemGetLog(string Name ,int ItemID){
    string newlog = (Name+"は"+ItemManager.returnItemName(ItemID)+"を手に入れた");
    MakeLog(newlog);
  }
  public static void UseItemLog(string Name,int ItemID){
    string newlog = (Name+"は"+ItemManager.returnItemName(ItemID)+"を使った");
    MakeLog(newlog);
  }

  public static void GetExp(string Name ,int Exp){
    string newlog = (Name+"は"+Exp+"の経験値を手に入れた");
    MakeLog(newlog);
  }

  public static void LvUp(string Name){
    string newlog = (Name+"はLVが上がった");
    AudioManager.AudioON(9);
    MakeLog(newlog);
  }
}
