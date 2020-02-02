using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime :Enemy
{
  Slime(){
    Name = "スライム";
    MaxHp = 10;
    CurrentHp = 10;
    Mp = 0;
    Str = 5;
    Def = 0;
    Exp = 1;
    Gold = 1;
    DropItem = 0;
    MoveSpeed = 1;
    MoveStatus = 0;
    AtackWaitTime = 1f;
    DeathCheck = false;
    AtackOn = false;
    MoveOn = false;
    MoveOnX = 0;
    MoveOnY = 0;
  }
  public override void Atack(GameObject Playerobj){
      PlayerManager.DamageHp(Str);
      Vector3 Playerpos = Playerobj.gameObject.transform.position;
      EfectManager.efecton("Kamitukiefect",Playerpos.x,Playerpos.y,Playerobj);//エフェクト作成
      AudioManager.AudioON(8);
  }
}
