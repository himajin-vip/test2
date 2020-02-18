using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayerp
{
  protected static Dictionary<AudioList,AudioSource> audioList = new Dictionary<AudioList,AudioSource>();
    public void SetUp(){
      audioList.Clear();
      audioList.Add(AudioList.CursolMove,GameObject.Find("AudioPlayerp").transform.Find("AudioCursolmove").GetComponent<AudioSource>());
      audioList.Add(AudioList.Kiri,GameObject.Find("AudioPlayerp").transform.Find("KiriSE").GetComponent<AudioSource>());
      audioList.Add(AudioList.CursolOn,GameObject.Find("AudioPlayerp").transform.Find("select").GetComponent<AudioSource>());
      audioList.Add(AudioList.Charge,GameObject.Find("AudioPlayerp").transform.Find("Charge").GetComponent<AudioSource>());
      audioList.Add(AudioList.ChargeAtack,GameObject.Find("AudioPlayerp").transform.Find("ChargeAtack").GetComponent<AudioSource>());
      audioList.Add(AudioList.Kaifuku,GameObject.Find("AudioPlayerp").transform.Find("kaihuku").GetComponent<AudioSource>());
      audioList.Add(AudioList.ItemGet,GameObject.Find("AudioPlayerp").transform.Find("ItemGet").GetComponent<AudioSource>());
      audioList.Add(AudioList.Kamituki,GameObject.Find("AudioPlayerp").transform.Find("kamituki").GetComponent<AudioSource>());
      audioList.Add(AudioList.LVUP,GameObject.Find("AudioPlayerp").transform.Find("LVUP").GetComponent<AudioSource>());
      audioList.Add(AudioList.Shiharai,GameObject.Find("AudioPlayerp").transform.Find("shiharai").GetComponent<AudioSource>());
    }
}
