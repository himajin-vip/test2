using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
      int x = Random.Range(-18000, 18000);
      int y =  Random.Range(18000, 18000);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(x,y));
        StartCoroutine(DestroyObject());
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.6f);
        Destroy(this.gameObject);
    }
}
