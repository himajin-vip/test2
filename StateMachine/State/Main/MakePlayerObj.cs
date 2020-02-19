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
        Move CameraMove = new CameraMove(Object.transform);
        MoveManager.Add(Object,move);
        MoveManager.Add(Camera.main.gameObject,CameraMove);
    }
    public void Update(){
        GameManager.SetState("Main");

    }
    public void End(){

    }
}
