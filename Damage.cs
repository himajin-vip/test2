using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test

public class Damage
{
  public int Check(int atklv ,int Str ,int deflv,int Vit){
    /////////攻撃力の算出
    int damage = 0;
    int DamageDice1 = 0;
    int DamageDice2 = 0;
    int ExDamage = (Str)/10;
    for(int i = 0; i <= 0+ExDamage ; i++){
      DamageDice1 = Random.Range(1,7);
      DamageDice2 = Random.Range(1,7);
      if(DamageDice1+DamageDice2 == 12){
        i--;
      }
      damage += (DamageDice1+DamageDice2);
    }

    /////////防御の算出
    int DamageBlock = 0;
    int BlockDice1 = 0;
    int BlockDice2 = 0;
    int ExBlock = (Vit)/10;
    for(int i = 0; i <= 0+ExBlock ; i++){
      BlockDice1 = Random.Range(1,7);
      BlockDice2 = Random.Range(1,7);
      DamageBlock += (BlockDice1+BlockDice2)/2;
    }

    ////////最終計算
    int FinalDamage = damage-DamageBlock;
    return FinalDamage;
  }
}
