using UnityEngine.SceneManagement;
using UnityEngine;

public class MakePlayerObj : IState
{
    private MoveManager MoveManager;
    public MakePlayerObj(MoveManager move){
        MoveManager = move;
    }
    
    public void Start(){
        GameObject obj = (GameObject)Resources.Load("prefab/Player/Player");
        GameObject Object = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
        Move move = new ContorolerMove(Object.transform,Object.GetComponent<Animator>(),new IntValue(3));
        MoveManager.Add(MoveState.Main,Object,move);
        

    }
    public void Update(){
        GameManager.SetState(States.CameraSetUp);

    }
    public void End(){

    }
}
