using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager
{
  public static string Name{get; private set;}
  private static string PassWord;
  public static SaveData SaveData{get; private set;} = new SaveData();
  public static SaveData LoadData{get; private set;} = new SaveData();
  public static bool NewGame{get ;private set;} = true;
  private static AccountData AccountData = new AccountData();
  private static Dictionary<int,int> test = new Dictionary<int, int>();


  public static bool NewCharacter(string name , string password){

    string Accountstr =  PlayerPrefs.GetString("Account","0");
    bool newPlayer = true;
    if(!(Accountstr == "0")){
      AccountData = JsonUtility.FromJson<AccountData> (Accountstr);
      foreach(string PlayingName in AccountData.Account){
        if(PlayingName == name){
          newPlayer = false;
        }
      }
      if(newPlayer){
        AccountData.Account.Add(name);
        AccountData.SaveData.Add("");
        Accountstr = JsonUtility.ToJson (AccountData);
        PlayerPrefs.SetString("Account",Accountstr);
        PlayerPrefs.SetString(name,password);
        PlayerPrefs.Save ();
        Name = name;
        PassWord = password;

        return true;
      }else{
        return false;
      }
    }else{
      AccountData.Account.Add(name);
      AccountData.SaveData.Add("");
      Accountstr = JsonUtility.ToJson (AccountData);
      PlayerPrefs.SetString("Account",Accountstr);
      PlayerPrefs.SetString(name,password);
      PlayerPrefs.Save ();
      Name = name;
      PassWord = password;
      return true;
    }
  }

  public static bool LoadGame(string name , string password){
    bool PlayingPlayer = false;
    string AccountName = "";
    string Accountstr =  PlayerPrefs.GetString("Account","0");
    AccountData = JsonUtility.FromJson<AccountData> (Accountstr);

    int count = 0;
    foreach(string accountname in AccountData.Account){
      if(accountname == name){
        AccountName = accountname;
        PlayingPlayer = true;
        break;
      }
      count++;
    }
    if(PlayingPlayer){
      if(PlayerPrefs.GetString(AccountName) == password){
        string savedatastr = AccountData.SaveData[count];
        LoadData = JsonUtility.FromJson<SaveData> (savedatastr);
        Name = name;
        PassWord = password;
        NewGame = false;
        return true;
      }else{
        return false;
      }
    }else{
      return false;
    }
  }

  public static void Save(){
    SaveData.Update();
    string SaveDatastr = JsonUtility.ToJson(SaveData);
    int count = 0;
    foreach(string Playername in AccountData.Account){
      if(Playername == Name){
        AccountData.SaveData[count] = SaveDatastr;
        break;
      }
      count++;
    }
    string Accountstr = JsonUtility.ToJson(AccountData);
    PlayerPrefs.SetString("Account",Accountstr);
    PlayerPrefs.Save ();
  }

}
