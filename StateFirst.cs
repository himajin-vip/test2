
public class StateFirst : UpdateState
{
    // Start is called before the first frame update
    public void Start()
    {
      ItemManager.SetUp();
      InventoryManager.SetUp();
      LogManager.SetUp();
      CameraManager.SetUp();
      UI_Manager.SetUp();
      ShortcutManager.SetUp();
      PlayerManager.SetUp("Fighter");
    }

    // Update is called once per frame
    public void Update()
    {

    }
    public void End(){

    }
}
