using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyState : IState
{
    private List<int> ShopList;
    GameObject ItemWindow;
    GameObject InfoWindow;
    Text InfoText;
    GameObject CursolObj;
    int CursolPos;
    RectTransform CursolTransform;
    private List<Text> TextList = new List<Text>();

    int BuyNumber;
    ShopState shopState = new ShopState();
    public void Start()
    {
        TextList.Clear();
        Player Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        ShopList = Player.Npc.ShopList;

        ItemWindow = GameObject.Find("ShopPanel").transform.Find("ItemWindow").gameObject;

        InfoWindow = GameObject.Find("ShopPanel").transform.Find("InfoWindow").gameObject;
        InfoText = InfoWindow.transform.Find("InfoText").GetComponent<Text>();
        InfoText.text = "";

        CursolObj = ItemWindow.transform.Find("SelectCursol").gameObject;
        CursolTransform = CursolObj.GetComponent<RectTransform>();

        Text GoldText = GameObject.Find("ShopPanel").transform.Find("GoldWindow").transform.Find("Text").GetComponent<Text>();
        GoldText.text = Player.SetGoldText(GoldText).text+"G";

        ItemWindow.SetActive(true);
        InfoWindow.SetActive(true);
        CursolObj.SetActive(true);

        CursolPos = 0;
        CursolTransform.anchoredPosition = new Vector2(10,-10);
        for(int i = 0; i < ShopList.Count ;i++){
            TextList.Add(GameObject.Find("ItemNameText"+i).GetComponent<Text>());
            ItemPrice itemPrice = new GetItemPrice().Get(new ItemID(ShopList[i]),new ItemPeace(1));
            ItemName itemName = new GetItemName().Get(new ItemID(ShopList[i]));
            TextList[i].text = itemName.GetValue()+" : "+itemPrice.GetValue()+"G : 1個";
        }
    }

    public void Update()
    {
        KeyCheck();
    }
    public void End(){
        if(CursolPos == 0){
            ItemWindow.SetActive(false);
            InfoWindow.SetActive(false);
            CursolObj.SetActive(false);
        }else{
           CursolObj.SetActive(false); 
        }
    }

    public void KeyCheck(){
        if(Input.GetKeyDown(KeyCode.W)&&(CursolPos>0)){
            BuyNumber = 1;
            UpdateText();
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y += 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos--;

            GetInfoText();
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.S)&&(CursolPos<ShopList.Count)){
            BuyNumber = 1;
            UpdateText();
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y -= 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos++;

            GetInfoText();
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            BuyNumber++;
            if(BuyNumber== 100){
                BuyNumber = 1;
            }
            UpdateText();
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            BuyNumber--;
            if(BuyNumber== 0){
                BuyNumber = 99;
            }
            UpdateText();
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
           if(CursolPos == 0){
               shopState.SetState("BuySellSelect");
           }
           else{
               shopState.getSelectItem(ShopList[CursolPos-1],BuyNumber);
               shopState.SetState("BuyCheck");
           }
            AudioManager.AudioON(3);
        }
    }

    public void GetInfoText(){
        if(CursolPos >0){
            ItemInfo itemInfo = new GetItemInfo().Get(new ItemID(ShopList[CursolPos-1]));
            InfoText.text = itemInfo.GetValue();
        }else{
            InfoText.text = "";
        }
    }
    public void UpdateText(){
        if(CursolPos != 0 && CursolPos <= (ShopList.Count)){
            ItemName itemName = new GetItemName().Get(new ItemID(ShopList[CursolPos-1]));
            ItemPrice itemPrice = new GetItemPrice().Get(new ItemID(ShopList[CursolPos-1]),new ItemPeace(BuyNumber));
            TextList[CursolPos-1].text = itemName.GetValue()+" : "+itemPrice.GetValue()+"G : "+BuyNumber+"個";
        }
    }


}
