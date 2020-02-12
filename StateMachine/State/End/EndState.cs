
using UnityEngine;
public class EndState : IState
{
   private endbutton endbutton; 
   public void Start(){
       endbutton = GameObject.Find("Button").GetComponent<endbutton>();
   }
   public void Update()
   {
       if(endbutton.toTItle){
        GameManager.SetState("ToTitle");
       }
       
   }
    public void End(){
        endbutton.toTItle = false;
        GameManager.Destroy(GameObject.Find("GameManager").gameObject);
    }
}
