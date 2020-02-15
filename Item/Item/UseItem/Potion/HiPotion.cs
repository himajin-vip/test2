using UnityEngine;
public class HiPotion : UseItem
{
  private Recovery Recovery = new Recovery(0.5f);
  public HiPotion(){
    Info = new ItemInfo("HPを50%回復します");
    Name = new ItemName("ハイポーション");
  }
  public override void Use(string Name){

  }
}
