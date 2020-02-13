using UnityEngine;
public class HiPotion : UseItem
{
  private Recovery Recovery = new Recovery(0.5f);
  public HiPotion(){
    Id = new ItemID(1);
    Info = new ItemInfo("HPを50%回復します");
    Name = new ItemName("ハイポーション");
    Price = new ItemPrice(100);
  }
  public override void Use(string Name){
    new UsePotion(Id,Recovery);
  }
}
