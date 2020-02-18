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
  Text GoldText;
  Playerp Playerp;

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
    GoldText = StateMenu.transform.Find("StatusPanel").transform.Find("GoldPanel").transform.Find("GoldText").GetComponent<Text>();
    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
  }
  public void Start(){
    StateMenu.SetActive(true);
    // NameText.text = Playerp.Name;
    // LvText.text = Playerp.Status.Lv.ToString();
    // HpText.text = Playerp.Status.Hp.currentValue+"/"+Playerp.Status.Hp.maxValue;
    // MpText.text = Playerp.Status.Mp.currentValue+"/"+Playerp.Status.Mp.maxValue;
    // StrText.text = Playerp.Status.Str.Value.ToString();
    // VitText.text = Playerp.Status.Vit.Value.ToString();
    // DexText.text = Playerp.Status.Dex.Value.ToString();
    // IntText.text = Playerp.Status.Int.Value.ToString();
    // ExpText.text = Playerp.Status.Exp.currentValue+"/"+Playerp.Status.Exp.maxValue;
    new SetGoldText().Set(GoldText);

  }
  public void CursolMove(int direction){}
  public void CursolOn(){
    MenuManager.SetMenuState("Main");
  }
  public void End(){
    StateMenu.SetActive(false);
  }
}
