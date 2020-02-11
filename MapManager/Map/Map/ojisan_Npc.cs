using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojisan_Npc : Npc
{
    public ojisan_Npc(){
        Name = "おじさん";
        HaveShop = true;
        ShopList = new List<int>(){0,1,100,200,300,400,500};
        MessageList = new List<string>(){
            "いらっしゃい",
            "何か買っていくかい？"
            };
    }
}
