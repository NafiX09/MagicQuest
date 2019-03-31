
using UnityEngine;

public class Detection_collision_ennemie : MonoBehaviour
{
    public static int nombre_de_mort = 0;
    public static bool Disparition_potion;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ennemie") { Debug.Log("<color=red>Ennemie Touché</color>"); nombre_de_mort++; gameObject.GetComponent<AudioSource>().Play(); }
        if (collision.gameObject.name == "green-potion") { Disparition_potion = true; }
    }

    public void Update()
    {
        if (nombre_de_mort == 3) { nombre_de_mort = 0; transform.position = new Vector3(0.021f, 0.149f, 0); }
        

    }



}
