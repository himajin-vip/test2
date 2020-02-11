using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public string Name{get; protected set;}
    public List<string> MessageList{get; protected set;}
    public int MessageCount{get; protected set;} = 0;
    public bool HaveShop{get; protected set;} = false;
    public void Talk(){
        if(MessageCount < MessageList.Count){
            UI_Manager.TalkCanvas.Set(Name,MessageList[MessageCount]);
            MessageCount++;
        }else{
            End();
        }
    }
    public virtual void End(){
        MessageCount = 0;
        UI_Manager.TalkCanvas.End();
        if(HaveShop){
            
        }
    }
}
