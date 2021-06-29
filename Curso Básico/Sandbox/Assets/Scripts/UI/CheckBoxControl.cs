using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckBoxControl : MonoBehaviour {

  public Text txt;
  Toggle toggle;

  void Start() {
    toggle = GetComponent<Toggle>();
  }

  void Update() {

  }

  public void Toggle() {
    txt.text = toggle.GetComponentInChildren<Text>().text;
  }
}
