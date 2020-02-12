using UnityEngine.SceneManagement;
using UnityEngine;

public class MakeNewCharactorState : IState
{
    public void Start(){
        SceneManager.LoadScene("Main");
    }
    public void Update(){
        GameObject obj = (GameObject)Resources.Load("prefab/Player/Player");
        GameObject Object = GameManager.Instantiate(obj, new Vector3(0,0,0), Quaternion.identity);
        Player newplayer = Object.GetComponent<Player>();
        newplayer.SetUp();
        newplayer.SetName(AccountData.Name);
        newplayer.Status.SetNewGame();
        GameManager.SetState("MainSetUp");
    }
    public void End(){

    }
}
