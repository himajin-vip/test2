using UnityEngine.SceneManagement;

public class ToTitleState : IState
{
    public void Start()
    {
        SceneManager.LoadScene("title");
    }

    // Update is called once per frame
    public void Update()
    {
        // GameManager.SetState("Title");
    }

    public void End(){

    }
}
