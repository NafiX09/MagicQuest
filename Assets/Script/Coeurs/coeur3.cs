﻿
using UnityEngine;

public class coeur3 : Detection_collision_ennemie
{
    public Animator anim;
   
  
    new void Update()
    {
        if (nombre_de_mort == 1) { anim.Play("Transformation_coeur"); }
        if (nombre_de_mort == 0) { anim.Play("coeur_de_base"); }
    }
}
