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
            animasyonlar.SetBool("ileri y�r�me",true);
            metin.text = "W tu�una bas�ld�";

        }
        else {
            animasyonlar.SetBool("ileri y�r�me", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            animasyonlar.SetBool("sa�a don", true);
            metin.text = "D tu�una bas�ld�";
        }
        else
        {
            animasyonlar.SetBool("sa�a don", false);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            animasyonlar.SetBool("sola don", true);
            metin.text = "A tu�una bas�ld�";
        }
        else
        {
            animasyonlar.SetBool("sola don", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            animasyonlar.SetBool("ger�", true);
            metin.text = "S tu�una bas�ld�";
        }
        else
        {
            animasyonlar.SetBool("ger�", false);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animasyonlar.SetBool("yumruk", true);
            metin.text = "SOL FARE tu�una bas�ld�";
        }
        else
        {
            animasyonlar.SetBool("yumruk", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animasyonlar.SetBool("z�pla", true);
            metin.text = "BO�LUK tu�una bas�ld�";
        }
        else
        {
            animasyonlar.SetBool("z�pla", false);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            metin.text = "SA� FARE tu�una bas�ld�";
            animasyonlar.SetBool("tekme",true);
        }
        else
        {
            animasyonlar.SetBool("tekme",false);
        }
        if (Input.GetKey(KeyCode.X))
        {
            metin.text = "X tu�una bas�ld�";
            animasyonlar.SetBool("xTekme", true);
        }
        else
        {
            animasyonlar.SetBool("xTekme", false);
        }


    }


}
