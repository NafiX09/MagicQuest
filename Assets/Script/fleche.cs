using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fleche : MonoBehaviour
{
    public float force;
    private bool durée_du_tir;
    public GameObject player;
    public float temp_du_tir;
    public Vector3 position_joueur;
    private bool sur_le_joueur = true ;

    public bool condition_left;
    public bool condition_right;
    public bool condition_up;
    public bool condition_down;


    void Start()
    {
        position_joueur = player.transform.position;
        transform.position = position_joueur;

    }


    void Update()
    {
        if (sur_le_joueur == true) {

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            position_joueur = player.transform.position;
            transform.position = position_joueur;
        }

        if (sur_le_joueur == false) { gameObject.GetComponent<SpriteRenderer>().enabled = true;  }

        if (Input.GetKeyDown(KeyCode.UpArrow)) { sur_le_joueur = false; StartCoroutine(up()); }
        if (Input.GetKeyDown(KeyCode.DownArrow)) { sur_le_joueur = false; StartCoroutine(down()); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { sur_le_joueur = false; StartCoroutine(left()); }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { sur_le_joueur = false; StartCoroutine(right()); }

        if (condition_down == true) { transform.Translate(Vector3.down * Time.deltaTime * force); }
        if (condition_up == true) { transform.Translate(Vector3.up * Time.deltaTime * force); }
        if (condition_left == true) { transform.Translate(Vector3.left * Time.deltaTime * force); }
        if (condition_right == true) { transform.Translate(Vector3.right * Time.deltaTime * force); }
    }

    public IEnumerator up (){ condition_up = true; yield return new WaitForSeconds(temp_du_tir); condition_up = false; sur_le_joueur = true; }
    public IEnumerator down() { condition_down = true; yield return new WaitForSeconds(temp_du_tir); condition_down = false; sur_le_joueur = true; }
    public IEnumerator left() { condition_left = true; yield return new WaitForSeconds(temp_du_tir); condition_left = false; sur_le_joueur = true; }
    public IEnumerator right() { condition_right = true; yield return new WaitForSeconds(temp_du_tir); condition_right = false; sur_le_joueur = true; }

    
    



}
