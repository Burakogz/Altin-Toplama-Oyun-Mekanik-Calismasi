using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{

    public bool oyunAktif = false;
    public int altinSayisi = 0;

    public UnityEngine.UI.Button baslaButonu;

    public UnityEngine.UI.Text altinsayisitext;
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    void Update()
    {
        
    }

     public void altinArttir()
    {
        altinSayisi += 1;
        altinsayisitext.text = "" + altinSayisi;
    }

    public void OyunaBasla()
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }
}
