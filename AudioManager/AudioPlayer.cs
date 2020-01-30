using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
  public AudioSource MySE;
  public AudioPlayer(string SEName){
    // Debug.Log("test");
    // AudioClip AC;
    // AC = (AudioClip)Resources.Load("SE/"+SEName);
    // MySE = gameObject.AddComponent<AudioSource>();
    // MySE.clip = AC;

  }
  public void Play(){
    MySE.Play();
  }
}
