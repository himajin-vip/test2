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

    // Start is called before the first frame update
    public void Start()
    {
        ShopList = GameManager.Player.Npc.ShopList;

        ItemWindow = GameObject.Find("ShopPanel").transform.Find("ItemWindow").gameObject;

        InfoWindow = GameObject.Find("ShopPanel").transform.Find("InfoWindow").gameObject;
        InfoText = InfoWindow.transform.Find("InfoText").GetComponent<Text>();
        InfoText.text = "";

        CursolObj = ItemWindow.transform.Find("SelectCursol").gameObject;
        CursolTransform = CursolObj.GetComponent<RectTransform>();

        ItemWindow.SetActive(true);
        InfoWindow.SetActive(true);
        CursolObj.SetActive(true);

        CursolPos = 0;
        CursolTransform.anchoredPosition = new Vector2(10,-10);

        for(int i = 0; i < ShopList.Count ;i++){
            TextList.Add(GameObject.Find("ItemNameText"+i).GetComponent<Text>());
            TextList[i].text = ItemManager.ReturnItemName(ShopList[i])+" : "+ItemManager.ReturnPrice(ShopList[i])+"G : 1個";
        }
    }

    // Update is called once per frame
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
        }
        if(Input.GetKeyDown(KeyCode.A)){
            BuyNumber--;
            if(BuyNumber== 0){
                BuyNumber = 99;
            }
            UpdateText();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
           if(CursolPos == 0){
               ShopState.SetState("BuySellSelect");
           }
           else{
               ShopState.getSelectItem(ShopList[CursolPos-1],BuyNumber);
               ShopState.SetState("BuyCheck");
           }
            AudioManager.AudioON(3);
        }
    }

    public void GetInfoText(){
        if(CursolPos >0){
            InfoText.text = ItemManager.ReturnInfo(ShopList[CursolPos-1]);
        }else{
            InfoText.text = "";
        }
    }
    public void UpdateText(){
        if(CursolPos != 0 && CursolPos <= (ShopList.Count)){
           TextList[CursolPos-1].text = ItemManager.ReturnItemName(ShopList[CursolPos-1])+" : "+ItemManager.ReturnPrice(ShopList[CursolPos-1])*BuyNumber+"G : "+BuyNumber+"個";
        }
    }


}
