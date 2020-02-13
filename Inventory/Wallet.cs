using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet
{
    private Gold Gold = new Gold(0);

    public void Add(Gold gold){
        Gold.Add(gold);
    }
    public bool Use(Gold gold){
        return Gold.Use(gold);
    }
    public Gold GetMoney(){
        return Gold;
    }
}
