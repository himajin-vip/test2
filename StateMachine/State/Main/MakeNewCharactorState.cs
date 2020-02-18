using UnityEngine.SceneManagement;
using UnityEngine;

public class MakeNewCharactorState : IState
{
    public void Start(){
        SceneManager.LoadScene("Main");
    }
    public void Update(){
        GameObject obj = (GameObject)Resources.Load("prefab/Playerp/Playerp");
        GameObject Object = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
        Playerp newPlayerp = Object.GetComponent<Playerp>();
        newPlayerp.SetUp();
        // newPlayerp.SetName(AccountData.Name);
        // newPlayerp.Status.SetNewGame();
        GameManager.SetState("MainSetUp");
    }
    public void End(){

    }
}
