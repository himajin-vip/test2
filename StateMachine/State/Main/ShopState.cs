using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopState : IState
{   
    private static Dictionary<string,IState> SceneList = new Dictionary<string, IState>();
    private static IState ShopScene;


    public static int SelectItemId{get; private set;}
    public static int SelectItemNumber{get; private set;}
    static ShopState(){

        SceneList.Add("BuySellSelect",new BuySellSelectState());
        SceneList.Add("Buy" ,new BuyState());
        SceneList.Add("BuyCheck", new BuyCheckState());


        SceneList.Add("ShopEnd",new ShopEndState());

    }
    public void Start()
    {
        Player player;
        GameObject ShopWindow = GameObject.Find("ShopCanvas").transform.Find("ShopPanel").gameObject;
        ShopWindow.SetActive(true);
        Text GoldText = ShopWindow.transform.Find("GoldWindow").transform.Find("Text").GetComponent<Text>();
        player  = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        GoldText.text = player.SetGoldText(GoldText).text+"G";

        ShopScene = SceneList["BuySellSelect"];
        ShopScene.Start();
    }

    // Update is called once per frame
    public void Update()
    {
        ShopScene.Update();
    }

    public void End(){
    
    }

    public void SetState(string NextScene){
        ShopScene.End();
        ShopScene = SceneList[NextScene];
        ShopScene.Start();    
    }

    public void getSelectItem(int itemid , int itemnumber){
        SelectItemId = itemid;
        SelectItemNumber = itemnumber;
    }
}
