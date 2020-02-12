using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSlime : Enemy
{
    BigSlime(){
      Name = "ビッグスライム";
      Lv = new StatusLv(10);
      Hp = new StatusHp(250 ,250);
      Mp = new StatusMp(0,0);
      Str = new StatusBattle(10);
      Vit = new StatusBattle(5);
      Exp = 40;
      Gold = 100;
      DropItemList.Add(new DropItem(1,5));
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
