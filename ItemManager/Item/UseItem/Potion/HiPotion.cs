using UnityEngine;
public class HiPotion : UseItem
{
  private float Recovery = 0.5f;
  public HiPotion(){
    Id = 1;
    Info = "HPを50%回復します";
  }
  public override void ItemUse(string Name){
    new UsePotion(Id,Recovery);
  }
}
