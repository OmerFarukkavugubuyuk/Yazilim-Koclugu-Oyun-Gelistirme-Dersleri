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

    Vector3 eksenler;

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
            Debug.Log("oyun bitti yandýn");
            skor = 0;
            karakter.transform.position = new Vector3(0, 2, -10);

        }
     
     */
    public void hareket() {

        eksenler= karakter.transform.position;  
        eksenler.z += Time.deltaTime *hareketHýzý ;
        karakter.transform.position = eksenler;     


    }
    public void zipla()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            fizikSistemi.AddForce(Vector3.up *ziplamaHýzý, ForceMode.Impulse);
            seskutusu.PlayOneShot(fýstsesi);
        }

      
    }

    

}
