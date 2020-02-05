using UnityEngine.SceneManagement;
public class StateEnd : UpdateState
{
    // Start is called before the first frame update
    public void Start()
    {
      SceneManager.LoadScene("end");
    }

    // Update is called once per frame
    public void Update()
    {
    }
    public void End(){

    }
}
