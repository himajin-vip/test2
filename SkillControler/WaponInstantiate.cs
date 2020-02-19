using UnityEngine;
public class WeaponInstantiate{
    public GameObject Get(GameObject weapon,float x,float y){
       return GameManager.Instantiate(weapon, new Vector3(x,y), Quaternion.identity);
    }
}