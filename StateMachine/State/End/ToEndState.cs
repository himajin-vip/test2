
using UnityEngine.SceneManagement;

public class ToEndState : IState
{
    // Start is called before the first frame update
    public void Start()
    {
        SceneManager.LoadScene("end");
    }

    // Update is called once per frame
    public void Update()
    {
        GameManager.SetState("End");
    }
    public void End(){

    }
}
