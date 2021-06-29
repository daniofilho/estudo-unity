using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour {

  public GameObject Coin;

  public void EventoBtn() {
    Instantiate(Coin, new Vector2(0, 0), Quaternion.identity);
  }
}
