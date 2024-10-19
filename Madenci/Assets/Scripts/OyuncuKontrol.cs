using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    public AudioClip gold, fall;


    public OyunKontrol OyunKontrol;
    private float hiz = 10;

    void Start()
    {
        
    }

    void Update()
    {
        if (OyunKontrol.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin")) {

            GetComponent<AudioSource>().PlayOneShot(gold,1f);

            OyunKontrol.altinArttir();
            Destroy(c.gameObject);
        
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {
            GetComponent<AudioSource>().PlayOneShot(fall, 1f);

            OyunKontrol.oyunAktif = false;
        }
    }
}
