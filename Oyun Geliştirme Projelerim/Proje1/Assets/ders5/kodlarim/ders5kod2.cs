using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ders5kod2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("zemin"))
        {
            Debug.Log("oyun bitti yandýn");
            ders5kod.kopya.skor = 0;
            ders5kod.kopya.karakter.transform.position=new Vector3(0, 1, -5);
        }
        if (other.gameObject.CompareTag("basarýlýEngel"))
        {
            Debug.Log("skor arttý engel gecildi");
            ders5kod.kopya.skor ++ ;

        }



    }
}
