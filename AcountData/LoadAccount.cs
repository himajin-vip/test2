﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAccount
{
    public bool LoadGame(string name , string password){
        bool PlayingPlayerp = false;
        string AccountName = "";

        AccountDataList AccountDataList = AccountData.AccountDataList;

        int count = 0;
        foreach(string accountname in AccountDataList.Account){
            if(accountname == name){
                AccountName = accountname;
                PlayingPlayerp = true;
                break;
            }
            count++;
        }
        if(PlayingPlayerp){
            if(PlayerPrefs.GetString(AccountName) == password){
                string savedatastr = AccountDataList.SaveData[count];
                AccountData.SetLoadData(JsonUtility.FromJson<SaveData> (savedatastr));
                AccountData.SetName(name);
                AccountData.SetPassWord(password);
                return true;
            }else{
                return false;
            }
        }
        return false;
    }
}
