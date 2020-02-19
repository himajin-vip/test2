using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Move
{
  protected Transform transform;
  protected Value movespeed;
  public abstract void Check();

  public void Down(){
      transform.Translate (0,-movespeed.GetIntValue(),0);
  }
  public void Up(){
      transform.Translate (0,movespeed.GetIntValue(),0);
  }
  public void Right(){
      transform.Translate (movespeed.GetIntValue(),0,0);
  }
  public void Left(){
      transform.Translate (-movespeed.GetIntValue(),0,0);
  }

}
