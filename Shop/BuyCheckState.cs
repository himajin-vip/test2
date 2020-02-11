using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCheckState : IState
{
    GameObject BuyComandWindow;
    GameObject CursolObj;
    RectTransform CursolTransform;
    int CursolPos;
    public void Start()
    {
        BuyComandWindow = GameObject.Find("ShopPanel").transform.Find("BuyComandWindow").gameObject;
        BuyComandWindow.SetActive(true);

        CursolObj = BuyComandWindow.transform.Find("SelectCursol").gameObject;
        CursolObj.SetActive(true);

        CursolTransform = CursolObj.GetComponent<RectTransform>();
        CursolTransform.anchoredPosition = new Vector2(10,-10);

        CursolPos = 0;
        
    }

    // Update is called once per frame
    public void Update()
    {
        KeyCheck();
    }
    public void End(){
        BuyComandWindow.SetActive(false);
        CursolObj.SetActive(false);
    }
    public void KeyCheck(){
        if(Input.GetKeyDown(KeyCode.W)&&(CursolPos>0)){
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y += 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos--;
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.S)&&(CursolPos<1)){
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y -= 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos++;
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            switch(CursolPos){
                case 0:
                    InventoryManager.ItemBuy(ShopState.SelectItemId,ShopState.SelectItemNumber);
                    ShopState.SetState("Buy");
                break;
                case 1:
                    ShopState.SetState("Buy");
                break;
            }
            AudioManager.AudioON(3);
        }
    }
    public void Buy(){

    }
}
