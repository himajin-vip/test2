using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopState : IState
{   
    private static Dictionary<string,IState> SceneList = new Dictionary<string, IState>();
    private static IState ShopScene;
    private  GameObject ShopWindow;

    public static int SelectItemId{get; private set;}
    public static int SelectItemNumber{get; private set;}
    public ShopState(){

        SceneList.Add("BuySellSelect",new BuySellSelectState());
        SceneList.Add("Buy" ,new BuyState());
        SceneList.Add("BuyCheck", new BuyCheckState());


        SceneList.Add("ShopEnd",new ShopEndState());

    }
    public void Start()
    {

        ShopWindow = GameObject.Find("ShopCanvas").transform.Find("ShopPanel").gameObject;
        ShopWindow.SetActive(true);

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

    public static void SetState(string NextScene){
        ShopScene.End();
        ShopScene = SceneList[NextScene];
        ShopScene.Start();    
    }

    public static void getSelectItem(int itemid , int itemnumber){
        SelectItemId = itemid;
        SelectItemNumber = itemnumber;
    }
}
