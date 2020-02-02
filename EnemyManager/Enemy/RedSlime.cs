using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSlime : Enemy
{
    RedSlime(){
      Name = "レッドスライム";
      MaxHp = 20;
      CurrentHp = 20;
      Mp = 0;
      Str = 10;
      Def = 5;
      Exp = 5;
      Gold = 10;
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
