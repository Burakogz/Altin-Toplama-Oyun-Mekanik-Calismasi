using System.Collections;
using System.Collections.Generic;
using UnityEngine.Timeline;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public OyunKontrol OyunKontrol;

    float hassasiyet = 3f;
    float yumusaklik = 2f;

    Vector2 gecisPos;
    Vector2 camPos;

    GameObject Oyuncu;
    void Start()
    {
        Oyuncu = transform.parent.gameObject;

        camPos.y=12f;
    }

    void Update()
    {
        if (OyunKontrol.oyunAktif)
        {
            Vector2 farePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            farePos = Vector2.Scale(farePos, new Vector2(hassasiyet * yumusaklik, hassasiyet * yumusaklik));
            gecisPos.x = Mathf.Lerp(gecisPos.x, farePos.x, 1f / yumusaklik);
            gecisPos.y = Mathf.Lerp(gecisPos.y, farePos.y, 1f / yumusaklik);

            camPos += gecisPos;

            transform.localRotation = Quaternion.AngleAxis(-camPos.y, Vector3.right);
            Oyuncu.transform.localRotation = Quaternion.AngleAxis(camPos.x, Oyuncu.transform.up);
        }
    }
}
