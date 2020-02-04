using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class MenuManager
{
  private static Dictionary<string,MenuState> MenuStateList = new Dictionary<string,MenuState>();
  private static MenuState MenuState;
  private static Text EquipWeaponText;
  private static Text EquipHeadText;
  private static Text EquipBodyText;
  private static Text EquipHandText;
  private static Text EquipFootText;
  private static Text EquipAccessoryText;
  private static bool InventoryEndfrag;

  public static void SetUp(){
    MenuStateList.Clear();
    InventoryEndfrag = true;
    GameObject EquipWindow = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").transform.Find("EquipWindow").transform.Find("EquipItemPanel").gameObject;
    EquipWeaponText = EquipWindow.transform.Find("WeaponText").GetComponent<Text>();
    EquipHeadText = EquipWindow.transform.Find("HeadText").GetComponent<Text>();
    EquipBodyText = EquipWindow.transform.Find("BodyText").GetComponent<Text>();
    EquipHandText = EquipWindow.transform.Find("HandText").GetComponent<Text>();
    EquipFootText = EquipWindow.transform.Find("FootText").GetComponent<Text>();
    EquipAccessoryText = EquipWindow.transform.Find("AccessoryText").GetComponent<Text>();

    MenuStateList.Add("Null",new NullState());

    MenuStateList.Add("Main",new MainState());
    MenuStateList["Main"].SetUp();

    MenuStateList.Add("Status",new StatusState());
    MenuStateList["Status"].SetUp();

    MenuStateList.Add("InventorySelect",new InventorySelectState());
    MenuStateList["InventorySelect"].SetUp();

    MenuStateList.Add("UseItem",new ItemUseState());
    MenuStateList["UseItem"].SetUp();

    MenuStateList.Add("UseComand",new UseComandState());
    MenuStateList["UseComand"].SetUp();

    MenuStateList.Add("SelectShortCut", new SelectShortCutState());
    MenuStateList["SelectShortCut"].SetUp();

    MenuStateList.Add("WeaponEquip", new WeaponEquipState());
    MenuStateList["WeaponEquip"].SetUp();

    MenuStateList.Add("WeaponEquipComand", new WeaponEquipComandState());
    MenuStateList["WeaponEquipComand"].SetUp();

    MenuStateList.Add("HeadEquip", new HeadEquipState());
    MenuStateList["HeadEquip"].SetUp();

    MenuStateList.Add("HeadEquipComand", new HeadEquipComandState());
    MenuStateList["HeadEquipComand"].SetUp();

    MenuStateList.Add("BodyEquip", new BodyEquipState());
    MenuStateList["BodyEquip"].SetUp();

    MenuStateList.Add("BodyEquipComand", new BodyEquipComandState());
    MenuStateList["BodyEquipComand"].SetUp();

    MenuStateList.Add("HandEquip", new HandEquipState());
    MenuStateList["HandEquip"].SetUp();

    MenuStateList.Add("HandEquipComand", new HandEquipComandState());
    MenuStateList["HandEquipComand"].SetUp();

    MenuStateList.Add("FootEquip", new FootEquipState());
    MenuStateList["FootEquip"].SetUp();

    MenuStateList.Add("FootEquipComand", new FootEquipComandState());
    MenuStateList["FootEquipComand"].SetUp();

    MenuStateList.Add("AccessoryEquip", new AccessoryEquipState());
    MenuStateList["AccessoryEquip"].SetUp();

    MenuStateList.Add("AccessoryEquipComand", new AccessoryEquipComandState());
    MenuStateList["AccessoryEquipComand"].SetUp();






    MenuState = MenuStateList["Null"];
  }

  public static void SetMenuState(string NextState){
    MenuState.End();
    MenuState = MenuStateList[NextState];
    MenuState.Start();
  }
  public static void MenuCursolMove(int direction){
    MenuState.CursolMove(direction);
  }
  public static void CursolOn(){
    MenuState.CursolOn();
  }
  public static void MenuOff(){
    MenuState = MenuStateList["Null"];
    MenuStateList["Main"].End();
    MenuStateList["Status"].End();
    InventoryEndfrag = true;
    MenuStateList["InventorySelect"].End();
    MenuStateList["UseItem"].End();
    MenuStateList["UseComand"].End();
    MenuStateList["SelectShortCut"].End();
    MenuStateList["WeaponEquip"].End();
    MenuStateList["WeaponEquipComand"].End();
    MenuStateList["HeadEquip"].End();
    MenuStateList["HeadEquipComand"].End();
    MenuStateList["BodyEquip"].End();
    MenuStateList["BodyEquipComand"].End();
    MenuStateList["HandEquip"].End();
    MenuStateList["HandEquipComand"].End();
    MenuStateList["FootEquip"].End();
    MenuStateList["FootEquipComand"].End();
    MenuStateList["AccessoryEquip"].End();
    MenuStateList["AccessoryEquipComand"].End();


    GameManager.StateSet(GameManager.ReturnLastState());

  }

  public static void InventoryEndFragToggle(bool frag){
    if(frag){
      InventoryEndfrag = true;
    }else{
      InventoryEndfrag = false;
    }
  }
  public static bool ReturnInventoryEndfrag(){
    return InventoryEndfrag;
  }
  public static void EquipWindowReset(){
    EquipWeaponText.text = ItemManager.returnItemName(PlayerManager.Player.Equip.Weapon.ItemId);
    EquipHeadText.text = ItemManager.returnItemName(PlayerManager.Player.Equip.Head.ItemId);
    EquipBodyText.text = ItemManager.returnItemName(PlayerManager.Player.Equip.Body.ItemId);
    EquipHandText.text = ItemManager.returnItemName(PlayerManager.Player.Equip.Hand.ItemId);
    EquipFootText.text = ItemManager.returnItemName(PlayerManager.Player.Equip.Foot.ItemId);
    EquipAccessoryText.text = ItemManager.returnItemName(PlayerManager.Player.Equip.Accessory.ItemId);

  }
}
