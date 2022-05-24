using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coindes : MonoBehaviour

{
    public AudioClip coindesClip;
    private AudioSource asrc;
    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
        coindesClip = Resources.Load<AudioClip>("Coin 1");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        asrc.PlayOneShot(coindesClip, 1);


    }
}
