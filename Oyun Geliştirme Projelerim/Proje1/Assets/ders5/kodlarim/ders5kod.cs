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

    public int h�z;
    public Text skorText;
    public int skor;

    public int hareketH�z�;
    public int ziplamaH�z�;

    public bool oyunDevamEdiyorMu;

    public GameObject karakter;

    Vector3 eksenler;

    public Rigidbody fizikSistemi;

    public AudioSource seskutusu;

    public AudioClip f�stsesi;

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





    /* 
     
        if (other.gameObject.CompareTag("zemin"))
        {
            Debug.Log("oyun bitti yand�n");
            skor = 0;
            karakter.transform.position = new Vector3(0, 2, -10);

        }
     
     */
    public void hareket() {

        eksenler= karakter.transform.position;  
        eksenler.z += Time.deltaTime *hareketH�z� ;
        karakter.transform.position = eksenler;     


    }
    public void zipla()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            fizikSistemi.AddForce(Vector3.up *ziplamaH�z�, ForceMode.Impulse);
            seskutusu.PlayOneShot(f�stsesi);
        }

      
    }

    

}
