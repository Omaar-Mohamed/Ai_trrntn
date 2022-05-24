using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    static AudioSource asrc;
    public static AudioClip coinsound;
    // Start is called before the first frame update
    void Start()
    {
        coinsound = Resources.Load<AudioClip>("Coin 1");

    }

    // Update is called once per frame
    void Update()
    {
    }
    public static void PlaySound(string Clip) {
        asrc.PlayOneShot(coinsound);

    }
}
