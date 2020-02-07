using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion
{
   public UsePotion(int ID,float Recovery){
    int recovery = (int)(PlayerManager.Player.Hp.maxValue*Recovery);
    PlayerManager.Player.Hp.Recovery(recovery);
    LogManager.UseItemLog(PlayerManager.Player.Name.Value,ID);
    new RecoveryHpLog(PlayerManager.Player.Name.Value,recovery);
    FiledText filedText = new FiledText();
    filedText.Make(recovery.ToString(),new Color(0,255,0),PlayerManager.Player.GameObject.transform);
    Efect Efect = new Efect();
    Efect.On("kaihukuefect",PlayerManager.Player.GameObject);
    AudioManager.AudioON(6);
   }
}
