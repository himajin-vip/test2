using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatus
{
  public StatusLv Lv{get; protected set;}
  public StatusHp Hp{get; protected set;}
  public StatusMp Mp{get; protected set;}
  public StatusBattle Str{get; protected set;}
  public StatusBattle Vit{get; protected set;}
  public StatusBattle Dex{get; protected set;}
  public StatusBattle Int{get; protected set;}
  public StatusExp Exp{get; protected set;}
  public  Equip Equip{get; protected set;}
  
}
