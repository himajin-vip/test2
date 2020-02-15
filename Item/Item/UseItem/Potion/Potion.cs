using UnityEngine;
public class Potion : UseItem
{
  private Recovery recovery = new Recovery(0.3f);
  public Potion(){
    Info = new ItemInfo("HPを30%回復します");
    Name = new ItemName("ポーション");
  }
  public override void Use(string Name){

  }
}
