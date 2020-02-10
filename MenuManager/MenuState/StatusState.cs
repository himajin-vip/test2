using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusState : IMenuState
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
    NameText.text = GameManager.Player.Name.Value;
    LvText.text = GameManager.Player.Lv.Value.ToString();
    HpText.text = GameManager.Player.Hp.currentValue+"/"+GameManager.Player.Hp.maxValue;
    MpText.text = GameManager.Player.Mp.currentValue+"/"+GameManager.Player.Mp.maxValue;
    StrText.text = GameManager.Player.Str.Value.ToString();
    VitText.text = GameManager.Player.Vit.Value.ToString();
    DexText.text = GameManager.Player.Dex.Value.ToString();
    IntText.text = GameManager.Player.Int.Value.ToString();
    ExpText.text = GameManager.Player.Exp.currentValue+"/"+GameManager.Player.Exp.maxValue;

  }
  public void CursolMove(int direction){}
  public void CursolOn(){
    MenuManager.SetMenuState("Main");
  }
  public void End(){
    StateMenu.SetActive(false);
  }
}
