using UnityEngine;
public class Potion : UseItem
{
  private Recovery recovery = new Recovery(0.3f);
  public Potion(){
    Id = new ItemID(0);
    Info = new ItemInfo("HPを30%回復します");
    Name = new ItemName("ポーション");
    Price = new ItemPrice(30);
  }
  public override void Use(string Name){
    new UsePotion(Id,recovery);
  }
}
