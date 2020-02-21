using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test

public class Damage
{
    private int Str = 25;
    private int Dex = 1;
    private int buki = 20;
    private int Lv = 5;
    private int Vit = 30;
    private int boug = 0;
    private int skill = 1;
 
  public Damage(Charactor Atacker,Charactor Defender,int SkillBonas){
    Str = Atacker.GetStatus(Statuss.Str).GetIntValue();
    Dex = Atacker.GetStatus(Statuss.Dex).GetIntValue();

    Lv = Defender.GetStatus(Statuss.Lv).GetIntValue();
    Vit = Defender.GetStatus(Statuss.Vit).GetIntValue();
    skill = SkillBonas;

    float Def = Vit/2+Lv/2+boug;
    float kihon = (Str+Dex/10);
    float exDef1 = 4000+Def;
    float exDef2 = (4000+Def*10);
    float exDef = exDef1/exDef2;
    int Damage = (int)(((kihon+buki)*skill)*exDef);
    Debug.Log(Damage+"のダメージ");
    Defender.ReduceStatusValue(Statuss.CurrentHp,new IntValue(Damage));
    Defender.DethCheck();
  }
}
