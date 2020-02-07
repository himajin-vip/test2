
public class StateMapMove : UpdateState
{

    public void Start()
    {
      ControlManager.KeyChenge("MapMove");
    }

    public void Update()
    {
      CameraManager.PlayerPosCheck();
      ControlManager.Check();
    }

    public void End(){

    }


}
