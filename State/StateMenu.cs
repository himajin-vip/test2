
public class StateMenu : UpdateState
{

    public void Start(){

    }

    public void Update(){
      ControlManager.MenuKey();
      UI_Manager.UiStatusUpdate();
    }
    public void End(){

    }

}
