using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopEndState : IState
{
    GameObject ShopWindow;
    // Start is called before the first frame update
    public void Start(StateData stateData)
    {
       ShopWindow = GameObject.Find("ShopPanel").gameObject;
       ShopWindow.SetActive(false);
    //    GameManager.SetState(GameManager.LastState);
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public StateData End()
    {
        return new StateData();
    }
}
