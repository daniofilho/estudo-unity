using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollbarHandler : MonoBehaviour {
  public Scrollbar scrollbar;
  public Button btn;

  private void Start() {
    btn.interactable = false;
  }

  public void ScrollbarHandle() {
    if (scrollbar.value == 0) {
      btn.interactable = true;
    }
  }
}
