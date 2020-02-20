public class SetEnemyLibrary: IState
{
    private EnemyManager enemyManager;
    public SetEnemyLibrary(EnemyManager e){
        enemyManager = e;
    }
    public void Start(){
        enemyManager.SetUp();
        GameManager.SetState(States.Main);
    }
    public void Update(){

    }
    public void End(){

    }
}