using UnityEngine;
public class Potion : UseItem
{
  private float Recovery = 0.3f;
  public Potion(){
    Id = 0;
    Info = "HPを30%回復します";
  }
  public override void ItemUse(string Name){
    new UsePotion(Id,Recovery);
  }
}
