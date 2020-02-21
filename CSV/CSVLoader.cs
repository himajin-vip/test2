using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
public class CSVLoader
{
    public List<string[]>  Getfile(Csvs csv){
        Csvs filename = csv;
        List<string[]> CSVDatas = new List<string[]>();
        TextAsset text = (TextAsset)Resources.Load("CSV/"+filename.ToString());
        StringReader reader = new StringReader(text.text);
        while (reader.Peek () > -1) {
			string s = reader.ReadLine ();
			CSVDatas.Add (s.Split (','));
		}
        return CSVDatas;
    }
    public void StatusLoad(Charactor chara){
        List<string[]> file = Getfile(Csvs.PlayerFirstStatus);
        string[] line = new string[10];
        foreach(string[] l in file){
            if(l[0] == chara.GetStatus(Statuss.Name).GetStringValue()){
                line = l;
            }
        }
        foreach(Statuss status in Enum.GetValues(typeof(Statuss))){
            if(status != Statuss.Name){
                chara.LoadStatus(status,new IntValue(int.Parse(line[(int)status])));
            }
        }
        foreach(Statuss status in Enum.GetValues(typeof(Statuss))){
            Debug.Log(chara.GetStatus(status).GetStringValue());
        }
    }
    public void EnemyLoad(Charactor chara){
        StatusLoad(chara);
        ///ドロップアイテムやらなんやらも処理したいよね
    }

}