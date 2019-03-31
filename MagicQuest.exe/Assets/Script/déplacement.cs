using System.Collections;
using UnityEngine;

public class déplacement : MonoBehaviour
{
    public float speed;
    public Animator anim;
    private float detectx;
    private float detecty;



    void Update()
    {
        if (Input.GetKey(KeyCode.Z)) { if (detectx == 0) { transform.Translate(Vector3.up * Time.deltaTime * speed); anim.Play("walk-back");  detecty = 1; } }
        if (Input.GetKey(KeyCode.S)) { if (detectx == 0) { transform.Translate(-Vector3.up * Time.deltaTime * speed); anim.Play("walk-front");  detecty = 1; } }
        if (Input.GetKeyUp(KeyCode.Z)) { anim.Play("idle-back");  detecty = 0; }
        if (Input.GetKeyUp(KeyCode.S)) { anim.Play("idle-front");  detecty = 0;  }

        
        if (Input.GetKey(KeyCode.Q)) { if (detecty == 0) { transform.Translate(-Vector3.right * Time.deltaTime * speed); anim.Play("walk-left");  detectx = 1; } }
        if (Input.GetKey(KeyCode.D)) { if (detecty == 0) { transform.Translate(Vector3.right * Time.deltaTime * speed); anim.Play("walk-right");  detectx = 1; } }
        if (Input.GetKeyUp(KeyCode.Q)) { anim.Play("Idle-left");  detectx = 0; }
        if (Input.GetKeyUp(KeyCode.D)) { anim.Play("Idle-right");  detectx = 0; }


        if (Input.GetKey(KeyCode.UpArrow)) { if (detectx == 0) { anim.Play("attack-back"); detecty = 1; } }
        if (Input.GetKey(KeyCode.DownArrow)) { if (detectx == 0) { anim.Play("attack-front"); detecty = 1; } }
        if (Input.GetKey(KeyCode.LeftArrow)) { if (detecty == 0) { anim.Play("attack-left"); detectx = 1; } }
        if (Input.GetKey(KeyCode.RightArrow)) { if (detecty == 0) { anim.Play("attack-right"); detectx = 1; } }

        if (Input.GetKeyUp(KeyCode.LeftArrow)) {  anim.Play("Idle-left"); detectx = 0;  }
        if (Input.GetKeyUp(KeyCode.RightArrow)) {  anim.Play("Idle-right"); detectx = 0;  }
        if (Input.GetKeyUp(KeyCode.UpArrow)) { anim.Play("idle-back"); detecty = 0; }
        if (Input.GetKeyUp(KeyCode.DownArrow)) { anim.Play("idle-front"); detecty = 0; }

        #region outils pour le devloppement 
        if (Input.GetKey(KeyCode.LeftControl)) { speed = 3; }
        if (Input.GetKeyUp(KeyCode.LeftControl)) { speed = 1; }
        #endregion



    }




}
