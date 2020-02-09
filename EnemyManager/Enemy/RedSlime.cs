using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSlime : Enemy
{
    RedSlime(){
      Name = new Name("レッドスライム");
      Lv = new Lv(5);
      Hp = new Hp(150 ,150);
      Mp = new Mp(0,0);
      Str = new Str(5);
      Vit = new Vit(1);
      Exp = 30;
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
