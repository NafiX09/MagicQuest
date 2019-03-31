using System.Collections;
using UnityEngine;

public class Annimationennemie : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim.Play("idle-front-ennemie");
        StartCoroutine(coroutine1());
    }

    IEnumerator coroutine1() { yield return new WaitForSeconds(5); anim.Play("idle-back-ennemie"); boucle1(); yield return null; }
    public void boucle1() { StartCoroutine(coroutine2()); }
    IEnumerator coroutine2() { yield return new WaitForSeconds(5); anim.Play("idle-front-ennemie"); boucle2(); yield return null; }
    public void boucle2() { StartCoroutine(coroutine1()); }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Balle") { gameObject.GetComponent<CapsuleCollider2D>().enabled = false; gameObject.GetComponent<SpriteRenderer>().enabled = false;  StartCoroutine(réaparition()); }
    }

    IEnumerator réaparition() { yield return new WaitForSeconds(7); gameObject.GetComponent<SpriteRenderer>().enabled = true; gameObject.GetComponent<CapsuleCollider2D>().enabled = true; }


}
