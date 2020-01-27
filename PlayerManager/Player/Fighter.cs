using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter :Player
{
  Fighter(){
    Name = "Player";
    Level = 1;
    MaxHp = 50;
    CurrentHp = 50;
    MaxMp = 10;
    CurrentMp = 10;
    Str = 1;
    Def = 0;
    MoveSpeed = 3;
    ChargeMoveSpeed = 1;
    Direction = 0;
    NomalMoveSpeed = 3;
  }
}
