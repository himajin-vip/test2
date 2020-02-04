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
      Def = 3;
      Exp = 10;
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
      int Damage = 0;
      int DamageDice1 = 0;
      int DamageDice2 = 0;
      for(int i = 0; i <= 0 ; i++){
        DamageDice1 = Random.Range(0,7);
        DamageDice2 = Random.Range(0,7);
        if(DamageDice1+DamageDice2 == 12){
          i--;
        }
        Damage += (DamageDice1+DamageDice2)/2+Str;
      }
        PlayerManager.Player.Hp.Damage(Damage);
        Vector3 Playerpos = Playerobj.gameObject.transform.position;
        EfectManager.efecton("Kamitukiefect",Playerpos.x,Playerpos.y,Playerobj);//エフェクト作成
        AudioManager.AudioON(8);
    }
}
