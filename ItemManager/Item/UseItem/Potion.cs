using UnityEngine;
public class Potion : UseItem
{
  private float Recovery = 0.3f;
  public Potion(){
    SetId(0);
    SetInfo("HPを30%回復します");
  }
  public override void ItemUse(string Name){
    int recovery = (int)(PlayerManager.Player.Hp.maxValue*Recovery);
    PlayerManager.Player.Hp.Recovery(recovery);
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,recovery);
    DamageTextManager.Make(recovery,PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,new Color(0,255,0),PlayerManager.Player.GameObject.transform);
    EfectManager.efecton("kaihukuefect",PlayerManager.Player.GameObject.transform.position.x,PlayerManager.Player.GameObject.transform.position.y,PlayerManager.Player.GameObject);
    AudioManager.AudioON(6);
  }
}
