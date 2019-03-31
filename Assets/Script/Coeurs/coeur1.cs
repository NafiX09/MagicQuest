
using UnityEngine;

public class coeur1 : Detection_collision_ennemie
{
    public Animator anim;

    new void Update()
    {
        if (nombre_de_mort == 3) { anim.Play("Transformation_coeur"); }
        if (nombre_de_mort == 0) { anim.Play("coeur_de_base"); }
    }
}
