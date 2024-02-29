using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ders3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text soruBasligiMetni;
    public Text sorununMetni;
    public int soruNumarasý;
    public Text sorunumarasýmetni;


    public Text aSikkiMetni;
    public Text bSikkiMetni;

    public string dogruCevap;
    public Image asikkidogruluk;
    public Image bsikkidogruluk;

    public Text sayacText;
    public float sayac=10;
    void Start()
    {
        soruUret();
    }

    // Update is called once per frame
    void Update()
    {
        sayac = sayac - Time.deltaTime;
        if ( sayac > 0 ) {
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");


        }else if ( sayac <= 0 )
        {
            soruBasligiMetni.text = " ";
            sorununMetni.text = " SÜRE BÝTTÝ ";


        }


    }
    public void dogrulukKontrol(string cevap) {
        dogruCevap = "ilham";

        sayac=sayac - Time.deltaTime;
        
        if (sayac>0)
        {

        
        
        if (dogruCevap==cevap)
        {
            sorununMetni.text = "tebrikler doðru cevap";
            asikkidogruluk.color = Color.green;
            bsikkidogruluk.color = Color.white;
            
        }
        else
        {
            sorununMetni.text = "hay aksi yanlýþ cevap";
            bsikkidogruluk.color = Color.red;
            asikkidogruluk.color = Color.white;
           
        }

}
    }
    public void soruUret() {

        asikkidogruluk.color=Color.white;
        bsikkidogruluk.color=Color.white;


            soruBasligiMetni.text = "genel kültür/teknoloji";
        sorununMetni.text = "inspimo nun anlamý nedir ? ";
        soruNumarasý = 1;
        sorunumarasýmetni.text = soruNumarasý.ToString();

        aSikkiMetni.text ="A)" + "ilham";
        bSikkiMetni.text = "B)"+"intikam";
    }

}
