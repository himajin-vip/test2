public class nullState : IState
{
    public void Start(StateData stateData){

    }
    public void Update(){

    }
    public StateData End(){
        return new StateData();
    }
}
