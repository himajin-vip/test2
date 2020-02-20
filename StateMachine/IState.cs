
public interface IState
{
    void Start(StateData stateData);
    void Update();
    StateData End();

}
