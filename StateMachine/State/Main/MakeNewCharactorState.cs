using UnityEngine.SceneManagement;

public class MakeNewCharactorState : IState
{
    public void Start(){
        SceneManager.LoadScene("Main");
    }
    public void Update(){
        MakePlayerObject playerObject= new MakePlayerObject();
        Player newplayer = playerObject.Object.GetComponent<Player>();
        newplayer.SetName(GameManager.AccountData.Name);
        newplayer.Status.SetNewGame();
        GameManager.SetState("MainSetUp");
    }
    public void End(){

    }
}
