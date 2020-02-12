using UnityEngine.SceneManagement;

public class MakeNewCharactorState : IState
{
    public void Start(){
        SceneManager.LoadScene("Main");
    }
    public void Update(){
        MakePlayerObject PlayerObject = new MakePlayerObject();
        Player = new NewPlayer(); 
        GameManager.SetState("MainSetUp");
    }
    public void End(){

    }
}
