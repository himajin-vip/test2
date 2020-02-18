using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingSlime : Enemy
{
    KingSlime(){
      // Name = "キングスライム";
      // Lv = 15;
      // Hp = new StatusHp(500 ,500);
      // Mp = new StatusMp(0,0);
      // Str = new StatusBattle(15);
      // Vit = new StatusBattle(10);
      // Exp = 50;
      // Gold = 500;
      // DropItemList.Add(new MakeDropIt.emData().Make(1,1,128));
      MoveSpeed = 1;
      MoveStatus = 0;
      AtackWaitTime = 1f;
      DeathCheck = false;
      AtackOn = false;
      MoveOn = false;
      MoveOnX = 0;
      MoveOnY = 0;
    }
}
