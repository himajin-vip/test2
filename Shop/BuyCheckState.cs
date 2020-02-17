using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCheckState : IState
{
    GameObject BuyComandWindow;
    GameObject CursolObj;
    RectTransform CursolTransform;
    int CursolPos;
    ShopState shopState = new ShopState();
    Player player;
    public void Start()
    {
        BuyComandWindow = GameObject.Find("ShopPanel").transform.Find("BuyComandWindow").gameObject;
        BuyComandWindow.SetActive(true);

        CursolObj = BuyComandWindow.transform.Find("SelectCursol").gameObject;
        CursolObj.SetActive(true);

        CursolTransform = CursolObj.GetComponent<RectTransform>();
        CursolTransform.anchoredPosition = new Vector2(10,-10);

        CursolPos = 0;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        
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
            new PlayAudio().Play(AudioList.CursolMove);
        }
        if(Input.GetKeyDown(KeyCode.S)&&(CursolPos<1)){
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y -= 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos++;
            new PlayAudio().Play(AudioList.CursolMove);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            switch(CursolPos){
                case 0:
                    // if(new BuyItem().Buy(new ItemID(ShopState.SelectItemId),new ItemPeace(ShopState.SelectItemNumber))){
                    //     shopState.SetState("Buy");
                    //     new PlayAudio().Play(AudioList.Shiharai);
                    // }
                break;
                case 1:
                    shopState.SetState("Buy");
                break;
            }
        }
    }
    public void Buy(){

    }
}
