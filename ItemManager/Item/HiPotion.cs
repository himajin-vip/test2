
public class HiPotion : UseItem
{
  public HiPotion(){
    SetId(1);
    SetRecovery(50);
  }
  public override void ItemUse(string Name){
    PlayerManager.RecoveryHp(ReturnRecovery());
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,ReturnRecovery());

  }
}
