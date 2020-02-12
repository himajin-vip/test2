using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  private static StateMachine SeanState = new StateMachine();

  public static AccountData AccountData{get; private set;} = new AccountData();
  public static Player Player{get; private set;}
  public static bool SetUp = false;
  public static string NowState{get; private set;}
  public static string LastState{get; private set;}

    static GameManager()
    {

      new InventoryManager();
      new MapManager();
      new ItemManager();
 
      //////タイトルシーン
      SeanState.Add("ToTitle",new ToTitleState());
      SeanState.Add("Title",new TitleState());
      SeanState.Add("NewGame", new NewGameState());
      SeanState.Add("Load", new LoadGameState());

      //////メインシーン
      SeanState.Add("MakeNewCharactor", new MakeNewCharactorState());
      SeanState.Add("MakeLoadCharactor",new MakeLoadCharactorState());
      SeanState.Add("Main",new MainState());
      SeanState.Add("MainSetUp",new MainSetUpState());
      SeanState.Add("MapMove",new MapMoveState());
      SeanState.Add("Town",new TownState());
      SeanState.Add("Menu", new MenuState());
      SeanState.Add("Shop", new ShopState());

      ///////エンドシーン
      SeanState.Add("ToEnd", new ToEndState());
      SeanState.Add("End", new EndState());
      
    }

    void Start(){
      DontDestroyOnLoad(gameObject);
      AccountData.SetUp();
      NowState = "Title";
      SeanState.Set("Title");
    }

    void Update()
    {
      SeanState.Update();
    }


    public static void SetState(string NextState){
      LastState = NowState;
      NowState = NextState;
      SeanState.Set(NextState);
    }

    public static void MakeNewCharactor(){
      MakePlayerObject PlayerObject = new MakePlayerObject();
      Player = new NewPlayer();
      Player.SetObjecct(PlayerObject.Object,PlayerObject.Object.GetComponent<Animator>());
      AccountData.Save();
    }
    public static void MakeLoadCharactor(){
      MakePlayerObject PlayerObject = new MakePlayerObject();
      Player = new LoadPlayer();
      Player.SetObjecct(PlayerObject.Object,PlayerObject.Object.GetComponent<Animator>());
      Player.Equip.PartsLoad(AccountData.LoadData.EquipWeapon,ItemType.Weapon);
      Player.Equip.PartsLoad(AccountData.LoadData.EquipHead,ItemType.Head);
      Player.Equip.PartsLoad(AccountData.LoadData.EquipBody,ItemType.Body);
      Player.Equip.PartsLoad(AccountData.LoadData.EquipHand,ItemType.Hand);
      Player.Equip.PartsLoad(AccountData.LoadData.EquipFoot,ItemType.Foot);
      Player.Equip.PartsLoad(AccountData.LoadData.EquipAccessory,ItemType.Accessory);
    }

    public static void PlayerDeathCheck(){
      if(Player.Hp.currentValue<=0){
        Player.Hp.Reset();
        AccountData.Save();
        SetState("ToEnd");
      }
    }

}
