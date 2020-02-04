using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager
{
  private static string Name;
  private static string PassWord;
  private static SaveData SaveData = new SaveData();
  private static bool NewGame = true;
  private static AccountData AccountData = new AccountData();


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

  public static void SetPlayerStatus(){
    if(!NewGame){
      PlayerManager.Player.LoadStatus(SaveData);
      InventoryManager.InventoryLoad(SaveData);
    }else{
      PlayerManager.Player.NewGame(Name);
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
        SaveData = JsonUtility.FromJson<SaveData> (savedatastr);
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
