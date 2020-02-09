using UnityEngine.SceneManagement;

public class MakeNewCharactorState : IState
{
    public void Start(){
        SceneManager.LoadScene("Main");
    }
    public void Update(){
        GameManager.MakeNewCharactor();     
        GameManager.SetState("Main");
    }
    public void End(){

    }
}
