using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter :Player
{
  Fighter(){
    Name = "TestPlayer";
    Level = 1;
    MaxHp = 50;
    CurrentHp = 50;
    MaxMp = 0;
    CurrentMp = 0;
    Str = 1;
    Def = 0;
    MoveSpeed = 3;
    ChargeMoveSpeed = 1;
    Direction = 0;
    NomalMoveSpeed = 3;
  }
}
