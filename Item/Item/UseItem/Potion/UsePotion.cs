using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsePotion
{
   public UsePotion(ItemID ID,Recovery Recovery){

      //////使う相手を選択できるように引数にしたほうがいい
      GameObject PlayerpObj = GameObject.FindGameObjectWithTag("Playerp").gameObject;
      Playerp Playerp = PlayerpObj.GetComponent<Playerp>();


      int recovery = (int)(Playerp.Status.Hp.maxValue*Recovery.GetValue());
      Playerp.Status.Hp.Recovery(recovery);
      // new UseItemLog(Playerp.Name,ID);
      FiledText filedText = new FiledText();
      filedText.Make(recovery.ToString(),new Color(0,255,0),PlayerpObj.transform);
      Efect Efect = new Efect();
      Efect.On("kaihukuefect",PlayerpObj);
      new PlayAudio().Play(AudioList.Kaifuku);
   }
}
