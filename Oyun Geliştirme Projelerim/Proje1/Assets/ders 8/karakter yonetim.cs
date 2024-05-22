using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class karakteryonetim : MonoBehaviour
{
    public SOkarakterler karakterözellikdosyasý;

    public Text isimtext;
    public Text türtext;

    public Text ozellikler;


    public AudioSource ses;

    public Image fotograf;
    void Start()
    {
        isimtext.text = karakterözellikdosyasý.isim;
        türtext.text = karakterözellikdosyasý.Tür;

        ozellikler.text = "can= " + karakterözellikdosyasý.can.ToString() + " \n" +
            "hasar= " + karakterözellikdosyasý.hasar.ToString() + "\n" +
            "ödül puaný= " + karakterözellikdosyasý.ödülPuaný.ToString() + "\n" +
            "hýz= " + karakterözellikdosyasý.hýz.ToString();

        GetComponent<Renderer>().material = karakterözellikdosyasý.renk;

        ses.clip = karakterözellikdosyasý.ses;

        fotograf.sprite = karakterözellikdosyasý.gorsel;

    }





}
