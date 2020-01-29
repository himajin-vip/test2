
public class Potion : UseItem
{
  private int Recovery = 30;
  public Potion(){
    SetId(0);
    SetInfo("HPを30回復します");
  }
  public override void ItemUse(string Name){
    PlayerManager.RecoveryHp(Recovery);
    LogManager.UseItemLog(Name,ReturnID());
    LogManager.RecoveryHpLog(Name,Recovery);

  }
}
