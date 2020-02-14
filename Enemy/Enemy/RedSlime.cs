﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSlime : Enemy
{
    RedSlime(){
      Name = "レッドスライム";
      Lv = 5;
      Hp = new StatusHp(150 ,150);
      Mp = new StatusMp(0,0);
      Str = new StatusBattle(5);
      Vit = new StatusBattle(1);
      Exp = 30;
      Gold = 50;
      DropItemList.Add(new MakeDropItemData().Make(0,1,128)); 
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
