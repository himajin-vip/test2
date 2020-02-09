using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountData
{
  public string Name{get; private set;}
  private string PassWord;
  public SaveData SaveData{get; private set;} = new SaveData();
  public SaveData LoadData{get; private set;} = new SaveData();
  public AccountDataList AccountDataList{get; private set;} = new AccountDataList();

 public void SetUp(){
   string Accountstr =  PlayerPrefs.GetString("Account","0");
   if(Accountstr != "0"){
    AccountDataList = JsonUtility.FromJson<AccountDataList> (Accountstr);
   }
 }
 public void SetLoadData(SaveData loaddata){
   LoadData = loaddata;
 }
 public void SetName(string name){
   Name = name;
 }
 public void SetPassWord(string password){
   PassWord = password;
 }
  public void Save(){
    SaveData.Update();
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
