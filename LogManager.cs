﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class LogManager
{
  private static Dictionary<int,Text> LogList = new Dictionary<int,Text>();
  private static int LogCount;
  public static void SetUp(){
    Text text0 = GameObject.Find("LogText0").GetComponent<Text>();
    text0.text = "";
    LogList.Add(0,text0);
    Text text1 = GameObject.Find("LogText1").GetComponent<Text>();
    text1.text = "";
    LogList.Add(1,text1);
    Text text2 = GameObject.Find("LogText2").GetComponent<Text>();
    text2.text = "";
    LogList.Add(2,text2);
    Text text3 = GameObject.Find("LogText3").GetComponent<Text>();
    text3.text = "";
    LogList.Add(3,text3);
    Text text4 = GameObject.Find("LogText4").GetComponent<Text>();
    text4.text = "";
    LogList.Add(4,text4);
    Text text5 = GameObject.Find("LogText5").GetComponent<Text>();
    text5.text = "";
    LogList.Add(5,text5);
    Text text6 = GameObject.Find("LogText6").GetComponent<Text>();
    text6.text = "";
    LogList.Add(6,text6);
    Text text7 = GameObject.Find("LogText7").GetComponent<Text>();
    text7.text = "";
    LogList.Add(7,text7);

  }
  public static void MakeLog(string NewText){
    if(!(LogCount == 7)){
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
}
