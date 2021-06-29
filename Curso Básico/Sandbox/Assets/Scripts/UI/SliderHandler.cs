using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderHandler : MonoBehaviour {

  public Text text;
  public Slider slider1;


  public void SlideHandler() {
    text.text = slider1.value.ToString();
  }
}
