using UnityEngine;
public class MapPosition
{       
        float camerax;
        float cameray;
        float objectsize = 32;
        float Mapsizex = 640;
        float Mapsizey = 384;
        public float MaxX;
        public float MaxY;
        public float MinX;
        public float MinY;
        public MapPosition(){
            camerax = Camera.main.gameObject.transform.position.x;
            cameray = Camera.main.gameObject.transform.position.y;
            MaxX = camerax + (Mapsizex/2)-objectsize;
            MinX = camerax - (Mapsizex/2)+objectsize;
            MaxY = cameray + (Mapsizey/2)-objectsize;
            MinY = cameray - (Mapsizey/2)+objectsize;
        }
}