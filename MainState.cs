
public class MainState : UpdateState
{

    public void Start()
    {
      ItemManager.SetUp();
      InventoryManager.SetUp();
      CameraManager.SetUp();
      UI_Manager.SetUp();
      ShortcutManager.SetUp();
      PlayerManager.SetUp("Fighter");
    }

    public void Update()
    {
      PlayerManager.PlayerDeathCheck();
      EnemyManager.EnemyUpdate();
      CameraManager.PlayerPosCheck();
      ControlManager.KeyCheck();
      UI_Manager.UiStatusUpdate();
      ShortcutManager.update();
      EnemyManager.MakeEnemy("Slime");
    }
    public void End(){

    }
}
