using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion
{
   public UsePotion(int ID,float Recovery){
    int recovery = (int)(GameManager.Player.Hp.maxValue*Recovery);
    GameManager.Player.Hp.Recovery(recovery);
    new UseItemLog(GameManager.Player.Name.Value,ID);
    new RecoveryHpLog(GameManager.Player.Name.Value,recovery);
    FiledText filedText = new FiledText();
    filedText.Make(recovery.ToString(),new Color(0,255,0),GameManager.Player.GameObject.transform);
    Efect Efect = new Efect();
    Efect.On("kaihukuefect",GameManager.Player.GameObject);
    AudioManager.AudioON(6);
   }
}
