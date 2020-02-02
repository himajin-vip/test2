﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter :Player
{
  public override void SetUp(){
    Name = "TestPlayer";
    Lv = 1;
    MaxHp = 50;
    CurrentHp = 50;
    MaxMp = 10;
    CurrentMp = 10;
    Str = 1;
    Vit = 1;
    Dex = 1;
    Int = 0;
    NextExp = 10;
    CurrentExp = 0;
    MoveSpeed = 3;
    ChargeMoveSpeed = 1;
    Direction = 0;
    NomalMoveSpeed = 3;
    Weapon = (GameObject)Resources.Load("prefab/Weapon/Sword");
    NormalAtack = new SwordNomalAtack();
    Skill = NormalAtack;
    ChargeSkill = new SwordChargeAtack();
  }

  public override void LvUp(){
    NextExp += NextExp;
    CurrentExp = 0;
    Lv++;
    Str += 2;
    Vit += 2;
    Dex += 1;
    Int += 1;
    MaxHp += 20;
    MaxMp += 10;
    CurrentHp = MaxHp;
    CurrentMp = MaxMp;
    LogManager.LvUp(Name);
  }
}
