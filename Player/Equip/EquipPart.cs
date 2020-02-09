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
    GameManager.AccountData.Save();
  }

  public void UnSet(int itemid){
    ItemManager.UnEquip(itemid);
    GameManager.AccountData.Save();
  }
}