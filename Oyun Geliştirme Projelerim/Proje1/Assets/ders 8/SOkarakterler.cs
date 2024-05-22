using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//properties

[CreateAssetMenu(fileName ="düþman karakterimiz",menuName ="düþman oluþturulsun/Yeni düþman")]

public class SOkarakterler : ScriptableObject
{
    //düþman

    public string isim;
    public string Tür;
    
    public int can;
    public int hasar;
    public int ödülPuaný;
    public int hýz;

    public Material renk;

    public AudioClip ses;

    public Sprite gorsel;



}
