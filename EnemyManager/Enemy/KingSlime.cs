using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingSlime : Enemy
{
    KingSlime(){
      Name = new Name("キングスライム");
      Lv = new Lv(15);
      Hp = new Hp(500 ,500);
      Mp = new Mp(0,0);
      Str = new Str(15);
      Vit = new Vit(10);
      Exp = 50;
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
}
