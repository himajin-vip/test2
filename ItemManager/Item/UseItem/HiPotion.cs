using UnityEngine;
public class HiPotion : UseItem
{
  private int Recovery = 50;
  public HiPotion(){
    SetId(1);
    SetInfo("HPを50回復します");
  }
  public override void ItemUse(string Name){
    PlayerManager.Player.Hp.Recovery(Recovery);
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,50);
    DamageTextManager.Make(Recovery,PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(0,255,0),PlayerManager.Player.GameObject.transform);
    EfectManager.efecton("kaihukuefect",PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,PlayerManager.Player.GameObject);
    AudioManager.AudioON(6);
  }
}
