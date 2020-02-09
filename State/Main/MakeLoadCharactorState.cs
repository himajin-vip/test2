using UnityEngine.SceneManagement;
public class MakeLoadCharactorState : IState
{
    public void Start()
    {
        SceneManager.LoadScene("Main");
    }

    public void Update(){
        GameManager.MakeLoadCharactor();
        GameManager.SetState("Main");
    }

    public void End(){

    }
}
