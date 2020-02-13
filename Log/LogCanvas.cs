using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogCanvas:MonoBehaviour
{
  private Dictionary<int,Text> LogList = new Dictionary<int,Text>();
  public Text text0;
  public Text text1;
  public Text text2;
  public Text text3;
  public Text text4;
  public Text text5;
  public Text text6;
  public Text text7;

  private int LogCount;
  public void SetUp(){
    LogList.Add(0,text0);
    LogList.Add(1,text1);
    LogList.Add(2,text2);
    LogList.Add(3,text3);
    LogList.Add(4,text4);
    LogList.Add(5,text5);
    LogList.Add(6,text6);
    LogList.Add(7,text7);
    LogRefresh();
  }
  public void LogRefresh(){
    for(int i = 0;i<=7;i++){
      LogList[i].text="";
    }
    LogCount = 0;
  }
  public void MakeLog(string NewText){
    if(NewLog(NewText)){
      AddLog(NewText);
    }
  }
  public bool NewLog(string NewText){
    if(LogCount <= 7){
      LogList[LogCount].text = NewText;
      LogCount++;
      return false;
    }
    return true;
  }
  public void AddLog(string addtext){
    int i=0;
    while(i<7){
      LogList[i].text = LogList[i+1].text;
      i++;
    }
    LogList[7].text = addtext;
  }
}
