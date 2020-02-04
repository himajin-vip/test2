using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage
{
  public int Check(int damage){
    int DamageBlock = 0;
    int BlockDice1 = 0;
    int BlockDice2 = 0;
    for(int i = 0; i <= 0 ; i++){
      BlockDice1 = Random.Range(0,7);
      BlockDice2 = Random.Range(0,7);
      DamageBlock += (BlockDice1+BlockDice2)/2;
    }
    int FinalDamage = damage-DamageBlock;
    if(FinalDamage>=0){
      return FinalDamage;
    }else{
      return 0;
    }
  }
}
