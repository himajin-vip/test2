using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusState : MenuState
{
  GameObject StateMenu;
  Text NameText;
  Text LvText;
  Text HpText;
  Text MpText;
  Text StrText;
  Text VitText;
  Text DexText;
  Text IntText;
  Text ExpText;

  public void SetUp(){
    StateMenu = GameObject.Find("MenuCanvas").transform.Find("StatusPanel").gameObject;
    NameText = StateMenu.transform.Find("StatusPanel").transform.Find("NamePanel").transform.Find("NameText").GetComponent<Text>();
    LvText = StateMenu.transform.Find("StatusPanel").transform.Find("LvPanel").transform.Find("LvText").GetComponent<Text>();
    HpText = StateMenu.transform.Find("StatusPanel").transform.Find("HpPanel").transform.Find("HpText").GetComponent<Text>();
    MpText = StateMenu.transform.Find("StatusPanel").transform.Find("MpPanel").transform.Find("MpText").GetComponent<Text>();
    StrText = StateMenu.transform.Find("StatusPanel").transform.Find("StrPanel").transform.Find("StrText").GetComponent<Text>();
    VitText = StateMenu.transform.Find("StatusPanel").transform.Find("VitPanel").transform.Find("VitText").GetComponent<Text>();
    DexText = StateMenu.transform.Find("StatusPanel").transform.Find("DexPanel").transform.Find("DexText").GetComponent<Text>();
    IntText = StateMenu.transform.Find("StatusPanel").transform.Find("IntPanel").transform.Find("IntText").GetComponent<Text>();
    ExpText = StateMenu.transform.Find("StatusPanel").transform.Find("ExpPanel").transform.Find("ExpText").GetComponent<Text>();
  }
  public void Start(){
    StateMenu.SetActive(true);
    NameText.text = PlayerManager.Player.Name.Value;
    LvText.text = PlayerManager.Player.Lv.Value.ToString();
    HpText.text = PlayerManager.Player.Hp.currentValue+"/"+PlayerManager.Player.Hp.maxValue;
    MpText.text = PlayerManager.Player.Mp.currentValue+"/"+PlayerManager.Player.Mp.maxValue;
    StrText.text = PlayerManager.Player.Str.Value.ToString();
    VitText.text = PlayerManager.Player.Vit.Value.ToString();
    DexText.text = PlayerManager.Player.Dex.Value.ToString();
    IntText.text = PlayerManager.Player.Int.Value.ToString();
    ExpText.text = PlayerManager.Player.Exp.currentValue+"/"+PlayerManager.Player.Exp.maxValue;

  }
  public void CursolMove(int direction){}
  public void CursolOn(){
    MenuManager.SetMenuState("Main");
  }
  public void End(){
    StateMenu.SetActive(false);
  }
}
