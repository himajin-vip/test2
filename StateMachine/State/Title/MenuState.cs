
public class MenuState : IState
{
    Controler controler = new MenuControler();
    public MenuState(){

    }
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
