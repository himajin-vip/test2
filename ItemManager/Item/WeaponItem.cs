
public class WeaponItem
{
  private int Id;
  private int Str;
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
}
