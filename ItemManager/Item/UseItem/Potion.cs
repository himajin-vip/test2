using UnityEngine;
public class Potion : UseItem
{
  private int Recovery = 30;
  public Potion(){
    SetId(0);
    SetInfo("HPを30回復します");
  }
  public override void ItemUse(string Name){
    PlayerManager.Player.Hp.Recovery(Recovery);
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,Recovery);
    DamageTextManager.Make(Recovery,PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(0,255,0),PlayerManager.Player.GameObject.transform);
    EfectManager.efecton("kaihukuefect",PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,PlayerManager.Player.GameObject);
    AudioManager.AudioON(6);
  }
}
