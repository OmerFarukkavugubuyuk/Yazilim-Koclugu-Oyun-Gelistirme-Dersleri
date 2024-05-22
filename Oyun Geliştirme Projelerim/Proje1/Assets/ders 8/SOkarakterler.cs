using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//properties

[CreateAssetMenu(fileName ="d��man karakterimiz",menuName ="d��man olu�turulsun/Yeni d��man")]

public class SOkarakterler : ScriptableObject
{
    //d��man

    public string isim;
    public string T�r;
    
    public int can;
    public int hasar;
    public int �d�lPuan�;
    public int h�z;

    public Material renk;

    public AudioClip ses;

    public Sprite gorsel;



}
