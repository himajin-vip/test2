using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime :Enemy
{
  Slime(){
    Name = "スライム";
    Lv = 1;
    Hp = new StatusHp(30,30);
    Mp = new StatusMp(0,0);
    Str = new StatusBattle(1);
    Vit = new StatusBattle(1);
    Exp = 15;
    Gold = 10;
    DropItemList.Add(new DropItem(0,128));
    DropItemList.Add(new DropItem(100,128));
    DropItemList.Add(new DropItem(200,128));
    DropItemList.Add(new DropItem(300,128));
    DropItemList.Add(new DropItem(400,128));
    DropItemList.Add(new DropItem(500,128));
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
