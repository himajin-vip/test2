using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AccountData
{
  public static string Name{get; private set;}
  private static string PassWord;
  public static SaveData SaveData{get; private set;} = new SaveData();
  public static SaveData LoadData{get; private set;} = new SaveData();
  public static AccountDataList AccountDataList{get; private set;} = new AccountDataList();
  public static Player Player;

 public static void SetUp(){
   string Accountstr =  PlayerPrefs.GetString("Account","0");
   if(Accountstr != "0"){
    AccountDataList = JsonUtility.FromJson<AccountDataList> (Accountstr);
   }
 }
 public static void PlayerSet()
 {
   Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
 }
 public static void SetLoadData(SaveData loaddata){
   LoadData = loaddata;
 }
 public static void SetName(string name){
   Name = name;
 }
 public static void SetPassWord(string password){
   PassWord = password;
 }
  public static void Save(){
    SaveData.Update(Player);
    string SaveDatastr = JsonUtility.ToJson(SaveData);
    int count = 0;
    foreach(string Playername in AccountDataList.Account){
      if(Playername == Name){
        AccountDataList.SaveData[count] = SaveDatastr;
        break;
      }
      count++;
    }
    string Accountstr = JsonUtility.ToJson(AccountDataList);
    PlayerPrefs.SetString("Account",Accountstr);
    PlayerPrefs.Save ();
  }

}
