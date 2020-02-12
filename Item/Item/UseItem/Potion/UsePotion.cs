using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion
{
   public UsePotion(int ID,float Recovery){

      //////使う相手を選択できるように引数にしたほうがいい
      GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player").gameObject;
      Player Player = PlayerObj.GetComponent<Player>();


      int recovery = (int)(Player.Status.Hp.maxValue*Recovery);
      Player.Status.Hp.Recovery(recovery);
      new UseItemLog(Player.Name,ID);
      new RecoveryHpLog(Player.Name,recovery);
      FiledText filedText = new FiledText();
      filedText.Make(recovery.ToString(),new Color(0,255,0),PlayerObj.transform);
      Efect Efect = new Efect();
      Efect.On("kaihukuefect",PlayerObj);
      AudioManager.AudioON(6);
   }
}
