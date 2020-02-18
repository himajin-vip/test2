using UnityEngine.SceneManagement;
public class MakeLoadCharactorState : IState
{
    public void Start()
    {
        SceneManager.LoadScene("Main");
    }

    public void Update(){
        MakePlayerpObject PlayerpObject = new MakePlayerpObject();
        Playerp Playerp = PlayerpObject.Object.GetComponent<Playerp>();
        SaveData LoadData = AccountData.LoadData;
        Playerp.SetName(LoadData.Name);
        Playerp.Status.SetLoadGame(LoadData);
        // Playerp.Equip.PartsLoad(AccountData.LoadData.EquipWeapon,ItemType.Weapon);
        // Playerp.Equip.PartsLoad(AccountData.LoadData.EquipHead,ItemType.Head);
        // Playerp.Equip.PartsLoad(AccountData.LoadData.EquipBody,ItemType.Body);
        // Playerp.Equip.PartsLoad(AccountData.LoadData.EquipHand,ItemType.Hand);
        // Playerp.Equip.PartsLoad(AccountData.LoadData.EquipFoot,ItemType.Foot);
        // Playerp.Equip.PartsLoad(AccountData.LoadData.EquipAccessory,ItemType.Accessory);
        // GameManager.SetState("MainSetUp");
    }

    public void End(){

    }
}
