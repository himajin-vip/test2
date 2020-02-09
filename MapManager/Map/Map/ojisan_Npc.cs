using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ojisan_Npc : Npc
{
    public ojisan_Npc(){
        Name = "おじさん";
        MessageList = new List<string>(){
            "いらっしゃい",
            "何か買っていくかい？"
            };
    }
}
