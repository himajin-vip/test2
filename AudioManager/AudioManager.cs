using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioManager
{
  private static Dictionary<int,AudioSource> AudioList = new Dictionary<int,AudioSource>();
    public static void SetUp(){
      AudioList.Clear();

      AudioList.Add(1,GameObject.Find("AudioPlayer").transform.Find("AudioCursolmove").GetComponent<AudioSource>());
      AudioList.Add(2,GameObject.Find("AudioPlayer").transform.Find("KiriSE").GetComponent<AudioSource>());
      AudioList.Add(3,GameObject.Find("AudioPlayer").transform.Find("select").GetComponent<AudioSource>());
      AudioList.Add(4,GameObject.Find("AudioPlayer").transform.Find("Charge").GetComponent<AudioSource>());
      AudioList.Add(5,GameObject.Find("AudioPlayer").transform.Find("ChargeAtack").GetComponent<AudioSource>());
      AudioList.Add(6,GameObject.Find("AudioPlayer").transform.Find("kaihuku").GetComponent<AudioSource>());
      AudioList.Add(7,GameObject.Find("AudioPlayer").transform.Find("ItemGet").GetComponent<AudioSource>());
      AudioList.Add(8,GameObject.Find("AudioPlayer").transform.Find("kamituki").GetComponent<AudioSource>());
      AudioList.Add(9,GameObject.Find("AudioPlayer").transform.Find("LVUP").GetComponent<AudioSource>());
    }
    public static void AudioON(int AudioNo){
      AudioList[AudioNo].Play();
    }
    public static void AudioOFF(int AudioNo){
      AudioList[AudioNo].Stop();
    }
}
