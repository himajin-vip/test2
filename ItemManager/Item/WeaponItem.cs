
public class WeaponItem
{
  private int Id;
  private int Str;
  private string Info;
  public void WeaponEquipment(Weapon weapon){
    weapon.DamageSet(Str);
  }
  public void SetStr(int str){
    Str = str;
  }
  public void SetId(int id){
    Id = id;
  }
  public int ReturnID(){
    return Id;
  }
  public void SetInfo(string info){
    Info = info;
  }
  public string ReturnInfo(){
    return Info;
  }
}
