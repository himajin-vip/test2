using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime :Enemy
{
  Slime(){
    Name = new Name("スライム");
    Lv = new Lv(1);
    Hp = new Hp(30,30);
    Mp = new Mp(0,0);
    Str = new Str(1);
    Vit = new Vit(1);
    Exp = 15;
    Gold = 1;
    DropItemList.Add(new DropItem(0,2));
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
