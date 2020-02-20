public class SetEnemyLibrary: IState
{
    private EnemyManager enemyManager;
    public SetEnemyLibrary(EnemyManager e){
        enemyManager = e;
    }
    public void Start(StateData stateData){
        enemyManager.SetUp();
        GameManager.SetState(States.Main,new StateData());
    }
    public void Update(){

    }

    public void End(){

    }
}