using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Map
{
  void Start(int LastMap);
  void Event(int EventNo);
  void End();
}
