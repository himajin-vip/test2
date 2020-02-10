public class EquipPart
{
  public int ItemId{get; private set;}

  public EquipPart(){
    ItemId = 9999;
  }
  public void Set(int itemid){
    ItemId = itemid;
    if(itemid != 9999){
      ItemManager.Equip(itemid);
    }
  }

  public void UnSet(int itemid){
    ItemManager.UnEquip(itemid);
  }
}