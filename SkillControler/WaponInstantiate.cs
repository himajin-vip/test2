using UnityEngine;
using System.Collections.Generic;
public class WeaponInstantiate{
    public GameObject Get(GameObject weaponprefab,float x,float y){
        GameObject weaponGameObject = GameManager.Instantiate(weaponprefab, new Vector3(x,y), Quaternion.identity);
        Weapon weapon = weaponGameObject.transform.GetComponent<Weapon>();
        for(int i = 0;i<weaponGameObject.transform.childCount;i++){
            weaponGameObject.transform.GetChild(i).GetComponent<WeaponCollider>().SetUp(weapon);
        }

        return weaponGameObject;
    }
}