using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // IMPORTAR ESSA CLASSE PRA UI

public class Counter : MonoBehaviour {
  private int counter = 0;
  public Text txtClickCounter;
  public Image imgCoin;
  public RawImage rImgGrass;


  private void OnMouseDown() {
    counter += 1;
    txtClickCounter.text = counter.ToString();
    imgCoin.fillAmount += 0.1f;
  }

  private void Update() {
    Rect temp = new Rect(rImgGrass.uvRect);
    temp.x += 0.1f * Time.deltaTime;

    rImgGrass.uvRect = temp;
  }
}
