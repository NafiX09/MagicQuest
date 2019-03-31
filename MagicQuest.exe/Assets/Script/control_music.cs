using UnityEngine;

public class control_music : MonoBehaviour
{
    Object[] Musics;

    public void Awake()
    {
        Musics = Resources.LoadAll("Musics" , typeof(AudioClip));
        GetComponent<AudioSource>().clip = Musics[0] as AudioClip;
    }
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying) { PlayRandomMusic(); }
    }
    public void PlayRandomMusic() { GetComponent<AudioSource>().clip = Musics[Random.Range(0, Musics.Length)] as AudioClip;
        GetComponent<AudioSource> ().Play ();
    }
}
