using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ders5kod : MonoBehaviour
{
    //vector3= 3 eksen / vector 2=iki eksen

    public int hýz;
    public Text skorText;
    public int skor;

    public int hareketHýzý;
    public int ziplamaHýzý;

    public bool oyunDevamEdiyorMu;

    public GameObject karakter;
    public GameObject kamera;

    Vector3 eksenler;
    Vector3 eksenlerkamera;

    public Rigidbody fizikSistemi;

    public AudioSource seskutusu;

    public AudioClip fýstsesi;

    public static ders5kod kopya { get; private set; }

    private void Awake()
    {
        if (kopya!=null && kopya!=this)
        {
            Destroy(this);
            return;
        }
        kopya = this;
        DontDestroyOnLoad(this.gameObject);
    }




    void Start()
    {
       
        eksenler=karakter.transform.position;
        eksenler=kamera.transform.position;
        oyunDevamEdiyorMu = true;
        skor = 0;
        skorText.text = "skorun = "+ skor;
    }

    // Update is called once per frame
    void Update()
    {
        zipla();
        hareket();
        skorText.text = "skorun = " + skor;
    }


    public void hareket() {

        eksenler= karakter.transform.position;  
        eksenlerkamera= kamera.transform.position;
        eksenlerkamera.z += Time.deltaTime * hareketHýzý;
        eksenler.z += Time.deltaTime *hareketHýzý ;
        karakter.transform.position = eksenler;    
        kamera.transform.position= eksenlerkamera;
        


    }
    public void zipla()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fizikSistemi.AddForce(Vector3.up *ziplamaHýzý, ForceMode.Impulse);
            seskutusu.PlayOneShot(fýstsesi);
        }

      
    }

    

}
