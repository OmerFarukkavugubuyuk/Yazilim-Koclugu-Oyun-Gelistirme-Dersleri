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
    void Start()
    {
        soruUret();
    }

    // Update is called once per frame
    void Update()
    {
      



    }
    public void dogrulukKontrol(string cevap) {
        dogruCevap = "ilham";

        if (dogruCevap==cevap)
        {
            sorununMetni.text = "tebrikler doðru cevap";
            asikkidogruluk.color = Color.green;
            
        }
        else
        {
            sorununMetni.text = "hay aksi yanlýþ cevap";
            bsikkidogruluk.color = Color.red;
           
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
