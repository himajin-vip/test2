using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerp
{
  protected static Dictionary<AudioList,AudioSource> audioList = new Dictionary<AudioList,AudioSource>();
    public void SetUp(){
      audioList.Clear();
      audioList.Add(AudioList.CursolMove,GameObject.Find("AudioPlayer").transform.Find("AudioCursolmove").GetComponent<AudioSource>());
      audioList.Add(AudioList.Kiri,GameObject.Find("AudioPlayer").transform.Find("KiriSE").GetComponent<AudioSource>());
      audioList.Add(AudioList.CursolOn,GameObject.Find("AudioPlayer").transform.Find("select").GetComponent<AudioSource>());
      audioList.Add(AudioList.Charge,GameObject.Find("AudioPlayer").transform.Find("Charge").GetComponent<AudioSource>());
      audioList.Add(AudioList.ChargeAtack,GameObject.Find("AudioPlayer").transform.Find("ChargeAtack").GetComponent<AudioSource>());
      audioList.Add(AudioList.Kaifuku,GameObject.Find("AudioPlayer").transform.Find("kaihuku").GetComponent<AudioSource>());
      audioList.Add(AudioList.ItemGet,GameObject.Find("AudioPlayer").transform.Find("ItemGet").GetComponent<AudioSource>());
      audioList.Add(AudioList.Kamituki,GameObject.Find("AudioPlayer").transform.Find("kamituki").GetComponent<AudioSource>());
      audioList.Add(AudioList.LVUP,GameObject.Find("AudioPlayer").transform.Find("LVUP").GetComponent<AudioSource>());
      audioList.Add(AudioList.Shiharai,GameObject.Find("AudioPlayer").transform.Find("shiharai").GetComponent<AudioSource>());
    }
}
