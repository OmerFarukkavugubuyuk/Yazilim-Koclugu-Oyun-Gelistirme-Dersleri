using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class karakteryonetim : MonoBehaviour
{
    public SOkarakterler karakter�zellikdosyas�;

    public Text isimtext;
    public Text t�rtext;

    public Text ozellikler;


    public AudioSource ses;

    public Image fotograf;
    void Start()
    {
        isimtext.text = karakter�zellikdosyas�.isim;
        t�rtext.text = karakter�zellikdosyas�.T�r;

        ozellikler.text = "can= " + karakter�zellikdosyas�.can.ToString() + " \n" +
            "hasar= " + karakter�zellikdosyas�.hasar.ToString() + "\n" +
            "�d�l puan�= " + karakter�zellikdosyas�.�d�lPuan�.ToString() + "\n" +
            "h�z= " + karakter�zellikdosyas�.h�z.ToString();

        GetComponent<Renderer>().material = karakter�zellikdosyas�.renk;

        ses.clip = karakter�zellikdosyas�.ses;

        fotograf.sprite = karakter�zellikdosyas�.gorsel;

    }





}
