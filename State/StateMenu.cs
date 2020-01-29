
public class StateMenu : UpdateState
{

    public void Start(){

    }

    public void Update(){
      ControlManager.MenuKey();
      UI_Manager.UiStatusUpdate();
      ShortcutManager.AllPiecesReset();
    }
    public void End(){

    }

}
