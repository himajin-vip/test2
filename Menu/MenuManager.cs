using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MenuManager
{
  private static Dictionary<string,IMenuState> MenuStateList = new Dictionary<string,IMenuState>();
  private static IMenuState MenuState;
  private static Dictionary<ItemType,Text> EquipTextList = new Dictionary<ItemType, Text>();
  private static bool InventoryEndfrag;
  public static ItemType InventoryType{get; private set;}
  private static Playerp Playerp;
  public static int SelectItemID;

  public void SetUp(){
    MenuStateList.Clear();
    EquipTextList.Clear();




    InventoryEndfrag = true;
    GameObject EquipWindow = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").transform.Find("EquipWindow").transform.Find("EquipItemPanel").gameObject;
    EquipTextList.Add(ItemType.Weapon,EquipWindow.transform.Find("WeaponText").GetComponent<Text>());
    EquipTextList.Add(ItemType.Head,EquipWindow.transform.Find("HeadText").GetComponent<Text>());
    EquipTextList.Add(ItemType.Body,EquipWindow.transform.Find("BodyText").GetComponent<Text>());
    EquipTextList.Add(ItemType.Hand,EquipWindow.transform.Find("HandText").GetComponent<Text>());
    EquipTextList.Add(ItemType.Foot,EquipWindow.transform.Find("FootText").GetComponent<Text>());
    EquipTextList.Add(ItemType.Accessory,EquipWindow.transform.Find("AccessoryText").GetComponent<Text>());

    MenuStateList.Add("Null",new NullState());

    MenuStateList.Add("Main",new MainMenuState());
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

    MenuStateList.Add("Equip", new EquipState());
    MenuStateList["Equip"].SetUp();

    MenuStateList.Add("EquipComand", new EquipComandState());
    MenuStateList["EquipComand"].SetUp();






    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
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
    MenuStateList["Equip"].End();
    MenuStateList["EquipComand"].End();

    GameManager.SetState(GameManager.LastState);

  }

  public static void InventoryEndFragToggle(bool frag){
    if(frag){
      InventoryEndfrag = true;
    }else{
      InventoryEndfrag = false;
    }
  }
  public static void SetInventoryType(ItemType itemtype){
    InventoryType = itemtype;
  }
  public static bool ReturnInventoryEndfrag(){
    return InventoryEndfrag;
  }
  public static void EquipWindowReset(){
    foreach(ItemType itemtype in Enum.GetValues(typeof(ItemType))){
      if(itemtype != ItemType.Use){
        if(Playerp.Equip.Parts[itemtype].ItemId!=9999){
          // ItemName itemName = new GetItemName().Get(new ItemID(Playerp.Equip.Parts[itemtype].ItemId));
          // EquipTextList[itemtype].text = itemName.GetValue();
        }
      }
    }

  }
}
