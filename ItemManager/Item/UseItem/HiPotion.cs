using UnityEngine;
public class HiPotion : UseItem
{
  private float Recovery = 0.5f;
  public HiPotion(){
    SetId(1);
    SetInfo("HPを50%回復します");
  }
  public override void ItemUse(string Name){
    int recovery = (int)(PlayerManager.Player.Hp.maxValue*Recovery);
    PlayerManager.Player.Hp.Recovery(recovery);
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,recovery);
    FiledText filedText = new FiledText();
    filedText.Make(recovery.ToString(),new Color(0,255,0),PlayerManager.Player.GameObject.transform);
    Efect Efect = new Efect();
    Efect.On("kaihukuefect",PlayerManager.Player.GameObject);
    AudioManager.AudioON(6);
  }
}
