using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAccount
{
    public bool LoadGame(string name , string password){
        bool PlayingPlayer = false;
        string AccountName = "";

        AccountDataList AccountDataList = GameManager.AccountData.AccountDataList;

        int count = 0;
        foreach(string accountname in AccountDataList.Account){
            if(accountname == name){
                AccountName = accountname;
                PlayingPlayer = true;
                break;
            }
            count++;
        }
        if(PlayingPlayer){
            if(PlayerPrefs.GetString(AccountName) == password){
                string savedatastr = AccountDataList.SaveData[count];
                GameManager.AccountData.SetLoadData(JsonUtility.FromJson<SaveData> (savedatastr));
                GameManager.AccountData.SetName(name);
                GameManager.AccountData.SetPassWord(password);
                return true;
            }else{
                return false;
            }
        }
        return false;
    }
}
