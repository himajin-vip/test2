
public class Potion : UseItem
{
  public Potion(){
    SetId(0);
    SetRecovery(30);
  }
  public override void ItemUse(string Name){
    PlayerManager.Player.GetComponent<Player>().RecoveryHp(ReturnRecovery());
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,ReturnRecovery());

  }
}
