using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ders5kod2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("zemin"))
        {
            Debug.Log("oyun bitti yand�n");
            ders5kod.kopya.skor = 0;
            ders5kod.kopya.karakter.transform.position=new Vector3(0, 2, -4);
            ders5kod.kopya.kamera.transform.position = new Vector3(11,5,-6);
        }
        if (other.gameObject.CompareTag("basar�l�Engel"))
        {
            Debug.Log("skor artt� engel gecildi");
            ders5kod.kopya.skor ++ ;

        }



    }
}
