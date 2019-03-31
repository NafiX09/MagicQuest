using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion_verte : Detection_collision_ennemie
{

     new void Update () { if (Disparition_potion == true ) { gameObject.SetActive(false); nombre_de_mort = 0; } }
}
