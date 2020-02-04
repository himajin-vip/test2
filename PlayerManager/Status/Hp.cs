using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hp
{
  public int maxValue{get; protected set;}
  public int currentValue{get; protected set;}

  public Hp(int max ,int current){
    maxValue = max;
    currentValue = current;
  }

  public void Damage(int damage){
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
      currentValue -= FinalDamage;
      DamageTextManager.Make(FinalDamage,PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(255,0,0),PlayerManager.Player.GameObject.transform);
      LogManager.MakeDamageLog(PlayerManager.Player.Name.Value,FinalDamage);
    }else{
      DamageTextManager.Make(0,PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(255,0,0),PlayerManager.Player.GameObject.transform);
      LogManager.MakeDamageLog(PlayerManager.Player.Name.Value,0);
    }
    DataManager.Save();
  }

  public void Recovery(int recovery){
    AudioManager.AudioON(6);
    currentValue += recovery;
    if(currentValue>maxValue){
      currentValue = maxValue;
    }
    DamageTextManager.Make(recovery,PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(0,255,0),PlayerManager.Player.GameObject.transform);
    EfectManager.efecton("kaihukuefect",PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,PlayerManager.Player.GameObject);
    DataManager.Save();
  }

  public void Reset(){
    currentValue = maxValue;
  }

  public void SetMax(int maxhp){
    maxValue = maxhp;
  }
  public void SetCurrent(int currenthp){
    currentValue = currenthp;
  }
  public void LvUp(int value){
    maxValue += value;
    currentValue = maxValue;
  }

}
