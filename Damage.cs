using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test

public class Damage
{
  public int Check(int Str ,int Vit){
    /////////攻撃力の算出
    int damage = 0;
    int DamageDice1 = 0;
    int DamageDice2 = 0;
    int ExDamage = (Str)/10;
    for(int i = 0; i <= 0+ExDamage ; i++){
      DamageDice1 = Random.Range(0,7);
      DamageDice2 = Random.Range(0,7);
      if(DamageDice1+DamageDice2 == 12){
        i--;
      }
      damage += (DamageDice1+DamageDice2)/2;
    }

    /////////防御の算出
    int DamageBlock = 0;
    int BlockDice1 = 0;
    int BlockDice2 = 0;
    int ExBlock = (Vit)/10;
    for(int i = 0; i <= 0+ExBlock ; i++){
      BlockDice1 = Random.Range(0,7);
      BlockDice2 = Random.Range(0,7);
      DamageBlock += (BlockDice1+BlockDice2)/2;
    }

    ////////最終計算
    int FinalDamage = damage-DamageBlock;
    if(FinalDamage>=0){
      return FinalDamage;
    }else{
      return 0;
    }
  }
}
