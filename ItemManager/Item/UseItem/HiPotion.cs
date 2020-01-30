
public class HiPotion : UseItem
{
  private int Recovery = 50;
  public HiPotion(){
    SetId(1);
    SetInfo("HPを50回復します");
  }
  public override void ItemUse(string Name){
    PlayerManager.RecoveryHp(Recovery);
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,50);

  }
}
