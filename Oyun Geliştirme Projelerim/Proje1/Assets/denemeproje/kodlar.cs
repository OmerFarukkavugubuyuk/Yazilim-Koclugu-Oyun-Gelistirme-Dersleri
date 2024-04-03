using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kodlar : MonoBehaviour
{
    public int hiz;
    public Animator animasyonlar;
    public Text metin;
                   

    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {
        hareket();
    }

    public void hareket() {
        float xEkseni = Input.GetAxis("Horizontal");
        float zEkseni = Input.GetAxis("Vertical");

        Vector3 hareketsistemi = new Vector3(xEkseni, 0.0f, zEkseni);

        this.transform.position += hareketsistemi * hiz * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            animasyonlar.SetBool("ileri yürüme",true);
            metin.text = "W tuþuna basýldý";

        }
        else {
            animasyonlar.SetBool("ileri yürüme", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animasyonlar.SetBool("saða don", true);
            metin.text = "D tuþuna basýldý";
        }
        else
        {
            animasyonlar.SetBool("saða don", false);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            animasyonlar.SetBool("sola don", true);
            metin.text = "A tuþuna basýldý";
        }
        else
        {
            animasyonlar.SetBool("sola don", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animasyonlar.SetBool("gerý", true);
            metin.text = "S tuþuna basýldý";
        }
        else
        {
            animasyonlar.SetBool("gerý", false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animasyonlar.SetBool("yumruk", true);
            metin.text = "SOL FARE tuþuna basýldý";
        }
        else
        {
            animasyonlar.SetBool("yumruk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animasyonlar.SetBool("zýpla", true);
            metin.text = "BOÞLUK tuþuna basýldý";
        }
        else
        {
            animasyonlar.SetBool("zýpla", false);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            metin.text = "SAÐ FARE tuþuna basýldý";
            animasyonlar.SetBool("tekme",true);
        }
        else
        {
            animasyonlar.SetBool("tekme",false);
        }
        if (Input.GetKey(KeyCode.X))
        {
            metin.text = "X tuþuna basýldý";
            animasyonlar.SetBool("xTekme", true);
        }
        else
        {
            animasyonlar.SetBool("xTekme", false);
        }


    }


}
