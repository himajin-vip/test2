using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime :Enemy
{
  Slime(){
    Name = new Name("スライム");
    Hp = new Hp(10,10);
    Mp = new Mp(0,0);
    Str = new Str(20);
    Vit = new Vit(10);
    Exp = 5;
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
}
