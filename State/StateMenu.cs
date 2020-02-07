
public class StateMenu : UpdateState
{

    public void Start(){
      ControlManager.KeyChenge("Menu");
    }

    public void Update(){
      ControlManager.Check();
      UI_Manager.UiStatusUpdate();
      ShortcutManager.AllPiecesReset();
    }
    public void End(){

    }

}
