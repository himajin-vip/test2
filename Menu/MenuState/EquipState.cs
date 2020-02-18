using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipState : IMenuState
{
  public List<Text> ItemTextList = new List<Text>();
  public List<int> InventoryList = new List<int>();
  public GameObject ItemWindow;
  public GameObject InfoWindow;
  public Text InfoWindowText;
  public GameObject Curesol;
  public RectTransform CursolTransform;
  public float CursolPosition = -10;
  public float newPosy;
  public int CursolPos;
  public int Inventorycount;

  public Playerp Playerp;


  public void SetUp(){
    ItemTextList.Clear();
    InventoryList.Clear();
    GameObject InventoryCanvas = GameObject.Find("MenuCanvas").transform.Find("InventoryPanel").gameObject;
    ItemWindow = InventoryCanvas.transform.Find("ItemWindow").gameObject;
    InfoWindow = InventoryCanvas.transform.Find("InfoWindow").gameObject;
    InfoWindowText = InventoryCanvas.transform.Find("InfoWindow").transform.Find("InfoText").GetComponent<Text>();
    Curesol = ItemWindow.transform.Find("SelectCursol").gameObject;
    CursolTransform = Curesol.GetComponent<RectTransform>();
    GameObject ItemPanel = ItemWindow.transform.Find("ItemPanel").gameObject;
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText0").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText1").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText2").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText3").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText4").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText5").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText6").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText7").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText8").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText9").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText10").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText11").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText12").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText13").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText14").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText15").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText16").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText17").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText18").GetComponent<Text>());
    ItemTextList.Add(ItemPanel.transform.Find("ItemNameText19").GetComponent<Text>());

    Playerp = GameObject.FindGameObjectWithTag("Playerp").GetComponent<Playerp>();
  }
  public void Start(){
    MenuManager.EquipWindowReset();
    InventoryList.Clear();
    Inventorycount = 0;
    CursolPos = 0;
    CursolPosition = -10;
    CursolTransform.anchoredPosition = new Vector2(10,-10);
    for(int i = 0; i<=19; i++){
      ItemTextList[i].text = "";
    }
    InfoWindowText.text = "";
    // InventoryList = new InventoryGetIDList().Get(MenuManager.InventoryType);
    foreach(int ItemID in InventoryList) {
      // ItemName itemName = new GetItemName().Get(new ItemID(ItemID));
      if(ItemID == Playerp.Equip.Parts[MenuManager.InventoryType].ItemId){
        // ItemTextList[Inventorycount].text = "E:"+itemName.GetValue()+" / "+Playerp.SetPeaceText(ItemTextList[Inventorycount],new ItemID(ItemID)).text+"個";
        Inventorycount++;
      }else{
        // ItemTextList[Inventorycount].text = itemName.GetValue()+" / "+Playerp.SetPeaceText(ItemTextList[Inventorycount],new ItemID(ItemID)).text+"個";
        Inventorycount++;
      }
    }
    Curesol.SetActive(true);
    ItemWindow.SetActive(true);
    InfoWindow.SetActive(true);
  }
  public void CursolMove(int direction){
    switch(direction){
      case 0:
        if(CursolPosition > ((-30*Inventorycount)-10)){
          newPosy = CursolPosition -= 30;
          CursolTransform.anchoredPosition = new Vector2(10,newPosy);
          CursolPos++;
        }
      break;
      case 1:
        if(CursolPosition < -10){
          newPosy = CursolPosition += 30;
          CursolTransform.anchoredPosition =new Vector2(10,newPosy);
          CursolPos--;
        }
      break;
    }
    if(!(CursolPos==0)){
      // ItemInfo itemInfo = new GetItemInfo().Get(new ItemID(InventoryList[CursolPos-1]));
      // InfoWindowText.text = itemInfo.GetValue();
    }else{
      InfoWindowText.text = "";
    }
  }
  public void CursolOn(){

    if(CursolPos == 0){
        MenuManager.InventoryEndFragToggle(true);
        MenuManager.SetMenuState("InventorySelect");
      }else{
        MenuManager.SelectItemID=InventoryList[CursolPos-1];
        MenuManager.SetMenuState("EquipComand");
      }
  }
  public void End(){
    Curesol.SetActive(false);
    if(MenuManager.ReturnInventoryEndfrag()){
      ItemWindow.SetActive(false);
      InfoWindow.SetActive(false);
    }
  }
}
