using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ders6kod : MonoBehaviour
{
    public float hiz = 10f;
    public Animator animasyonlar;

    public Text metin;

    void Start()
    {
        
    }

    
    void Update()
    {
        ObjeHareket();
        



    }

    public void ObjeHareket()
    {
        float xEkseni = Input.GetAxis("Horizontal");
        float zEkseni = Input.GetAxis("Vertical");

        Vector3 hareketsistemi = new Vector3(xEkseni, 0.0f, zEkseni);

        this.transform.position += hareketsistemi * hiz * Time.deltaTime;


        if (Input.GetKey(KeyCode.W))
        {
            animasyonlar.SetBool("ileri y�r�me", true);
            metin.text = "W tu�u bas�l�yor";
        }
        else
        {
            animasyonlar.SetBool("ileri y�r�me", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            animasyonlar.SetBool("sola don", true);
            metin.text = "A tu�u bas�l�yor";
        }
        else
        {
            animasyonlar.SetBool("sola don", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            metin.text = "D tu�u bas�l�yor";
            animasyonlar.SetBool("sa�a don", true);
        }
        else
        {
            animasyonlar.SetBool("sa�a don", false);
        }


    }



}
