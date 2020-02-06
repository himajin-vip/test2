using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSlime : Enemy
{
    BigSlime(){
      Name = new Name("ビッグスライム");
      Lv = new Lv(10);
      Hp = new Hp(250 ,250);
      Mp = new Mp(0,0);
      Str = new Str(10);
      Vit = new Vit(5);
      Exp = 40;
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
