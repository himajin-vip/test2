﻿using UnityEngine.SceneManagement;
public class MakeLoadCharactorState : IState
{
    public void Start()
    {
        SceneManager.LoadScene("Main");
    }

    public void Update(){
        MakePlayerObject playerObject = new MakePlayerObject();
        Player player = playerObject.Object.GetComponent<Player>();
        SaveData LoadData = GameManager.AccountData.LoadData;
        player.SetName(LoadData.Name);
        player.Status.SetLoadGame(LoadData);
        // Player.Equip.PartsLoad(AccountData.LoadData.EquipWeapon,ItemType.Weapon);
        // Player.Equip.PartsLoad(AccountData.LoadData.EquipHead,ItemType.Head);
        // Player.Equip.PartsLoad(AccountData.LoadData.EquipBody,ItemType.Body);
        // Player.Equip.PartsLoad(AccountData.LoadData.EquipHand,ItemType.Hand);
        // Player.Equip.PartsLoad(AccountData.LoadData.EquipFoot,ItemType.Foot);
        // Player.Equip.PartsLoad(AccountData.LoadData.EquipAccessory,ItemType.Accessory);
        // GameManager.SetState("MainSetUp");
    }

    public void End(){

    }
}
