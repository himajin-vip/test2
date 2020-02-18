public class EquipPart
{
  public int ItemId{get; private set;}

  public EquipPart(){
    ItemId = 9999;
  }
  public void Set(int itemid,Playerp Playerp){
    ItemId = itemid;
    if(itemid != 9999){
      // ItemManager.Equip(itemid,Playerp);
    }
  }

  public void UnSet(int itemid,Playerp Playerp){
    // ItemManager.UnEquip(itemid,Playerp);
  }
}