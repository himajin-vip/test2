using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySellSelectState : IState
{
    GameObject ShopWindow;
    GameObject CursolObj;
    RectTransform CursolTransform;
    int CursolPos;
    ShopState shopState = new ShopState();

    public void Start(StateData stateData)
    {
        ShopWindow = GameObject.Find("ShopPanel").gameObject;
        CursolObj = GameObject.Find("ShopPanel").transform.Find("SelectWindow").transform.Find("SelectCursol").gameObject;
        CursolTransform= CursolObj.GetComponent<RectTransform>();

        CursolObj.SetActive(true);
        
        CursolPos = 0;
        CursolTransform.anchoredPosition = new Vector2(10,-10);
    }

    // Update is called once per frame
    public void Update()
    {
        KeyCheck();
        
    }
    public void End()
    {
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
        if(Input.GetKeyDown(KeyCode.S)&&(CursolPos<2)){
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y -= 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos++;
            new PlayAudio().Play(AudioList.CursolMove);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            switch(CursolPos){
                case 0:
                    shopState.SetState("Buy");
                break;
                case 1:
                break;
                case 2:
                    shopState.SetState("ShopEnd");
                break;
            }
            new PlayAudio().Play(AudioList.CursolOn);
        }
    }
}
