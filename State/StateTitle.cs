using UnityEngine.SceneManagement;
public class StateTitle : UpdateState
{
    // Start is called before the first frame update
    public void Start()
    {
      SceneManager.LoadScene("title");
    }

    // Update is called once per frame
    public void Update()
    {

    }
    public void End(){

    }
}
