
public class StateMapMove : UpdateState
{

    public void Start()
    {

    }

    public void Update()
    {
      CameraManager.PlayerPosCheck();
      ControlManager.AtackKeyUpCheck();
    }

    public void End(){

    }


}
