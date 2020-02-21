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

}