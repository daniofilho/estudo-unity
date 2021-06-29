using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

  public float velocity = 2.5f;

  void Update() {
    // bullet movement
    transform.Translate(new Vector2(velocity * Time.deltaTime, 0));
  }
  void OnCollisionEnter2D(Collision2D TargetObject) {

    // Destroy enemy on collide
    if (TargetObject.gameObject.CompareTag("Enemy")) {
      Destroy(TargetObject.gameObject);
      Destroy(this.gameObject);
    }
  }
}
