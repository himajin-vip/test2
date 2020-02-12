
public class MenuState : IState
{
    Controler controler = new MenuControler();
    public void Start()
    {

    }
    public void Update()
    {
        controler.Check();
    }

    public void End(){

    }
}
