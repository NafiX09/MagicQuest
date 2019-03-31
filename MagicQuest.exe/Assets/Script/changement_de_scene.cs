
using UnityEngine;
using UnityEngine.SceneManagement;

public class changement_de_scene : MonoBehaviour
{
    public string LevelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            SceneManager.LoadScene(LevelToLoad);
    }
}
