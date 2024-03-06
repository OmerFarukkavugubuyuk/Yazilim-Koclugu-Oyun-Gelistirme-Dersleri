using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Text isimsoyisim;
    public Text adres;
    public Text websitesi;
    public Text telefon;
    public Text mail;
    public Text biografi;

    public Image resim;
    public Sprite profilresmi;

    public Sprite [] resimlerim;

    // Start is called before the first frame update
    void Start()
    {
        biografi.text = "Bilgiler cekilirken hata olustu";
        resim.gameObject.SetActive(false);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bilgilerimigetir()
    {
        resim.gameObject.SetActive(true);
        isimsoyisim.text = "Omer Faruk Kavugubuyuk";
        adres.text = "Ahmet Kabakli Ogrenci Yurdu";
        websitesi.text = "inspimo.com";
        telefon.text = "+90(553) 673 27 46";
        mail.text = "omrkvby@gmail.com";
        biografi.text = "Firat universitesinde okuyor iþ tecrübem yok.";
        resim.sprite= profilresmi;


    }
    public void resimlerigetir(int index) {

        resim.sprite = resimlerim[index];
        
    }
}
