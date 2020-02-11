using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySellSelectState : IState
{
    GameObject ShopWindow;
    GameObject CursolObj;
    RectTransform CursolTransform;
    int CursolPos;
    // Start is called before the first frame update
    public void Start()
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
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.S)&&(CursolPos<2)){
            Vector2 pos = CursolTransform.anchoredPosition;
            pos.y -= 30;
            CursolTransform.anchoredPosition = pos;
            CursolPos++;
            AudioManager.AudioON(1);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            switch(CursolPos){
                case 0:
                    ShopState.SetState("Buy");
                break;
                case 1:
                break;
                case 2:
                    ShopState.SetState("ShopEnd");
                break;
            }
            AudioManager.AudioON(3);
        }
    }
}
