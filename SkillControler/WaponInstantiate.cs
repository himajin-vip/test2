using UnityEngine;
using System.Collections.Generic;
public class WeaponInstantiate{
    public GameObject Get(GameObject weaponprefab,float x,float y,List<Enemy> hitlist){
        GameObject weaponGameObject = GameManager.Instantiate(weaponprefab, new Vector3(x,y), Quaternion.identity);
        Weapon weapon = weaponGameObject.transform.GetComponent<Weapon>();
        weapon.SetUp(hitlist);
        for(int i = 0;i<weaponGameObject.transform.childCount;i++){
            weaponGameObject.transform.GetChild(i).GetComponent<WeaponCollider>().SetUp(weapon);
        }

        return weaponGameObject;
    }
}