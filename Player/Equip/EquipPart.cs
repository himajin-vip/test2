public class EquipPart
{
  public int ItemId{get; private set;}

  public EquipPart(){
    ItemId = 9999;
  }
  public void Set(int itemid,Player player){
    ItemId = itemid;
    if(itemid != 9999){
      ItemManager.Equip(itemid,player);
    }
  }

  public void UnSet(int itemid,Player player){
    ItemManager.UnEquip(itemid,player);
  }
}