using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNewAccount
{
        public bool Make(string name , string password){
        string Accountstr =  PlayerPrefs.GetString("Account","0");
        bool newPlayerp = true;
        
        if(!(Accountstr == "0"))////////アカウントデータ有り
        {
            AccountDataList AccountDataList = AccountData.AccountDataList; 
            foreach(string PlayingName in AccountDataList.Account){
                if(PlayingName == name){
                newPlayerp = false;
                }
            }
            if(newPlayerp){
                AccountDataList.Account.Add(name);
                AccountDataList.SaveData.Add("");
                Accountstr = JsonUtility.ToJson (AccountDataList);
                PlayerPrefs.SetString("Account",Accountstr);
                PlayerPrefs.SetString(name,password);
                PlayerPrefs.Save ();
                AccountData.SetName(name);
                AccountData.SetPassWord(password);
                return true;
            }else{
                return false;
            }
        }else/////////アカウントデータ無し
        {
            AccountDataList AccountDataList = AccountData.AccountDataList; 
            AccountDataList.Account.Add(name);
            AccountDataList.SaveData.Add("");
            Accountstr = JsonUtility.ToJson (AccountDataList);
            PlayerPrefs.SetString("Account",Accountstr);
            PlayerPrefs.SetString(name,password);
            PlayerPrefs.Save ();
            AccountData.SetName(name);
            AccountData.SetPassWord(password);
            return true;
        }
    }


}
