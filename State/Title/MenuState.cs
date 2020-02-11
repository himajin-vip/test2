
public class MenuState : IState
{
    public void Start()
    {
        ControlManager.KeyChenge("Menu");
    }
    public void Update()
    {
        ControlManager.Check();
    }

    public void End(){

    }
}
