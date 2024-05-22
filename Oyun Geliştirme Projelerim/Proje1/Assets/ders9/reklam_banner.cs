using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    using GoogleMobileAds;
    using GoogleMobileAds.Api;

public class reklam_banner : MonoBehaviour
{
#if UNITY_EDITOR
    string _reklamID = "ca-app-pub-3940256099942544/6300978111";

#endif

    BannerView _banner;
    private void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) => 
        {
        
        });

        bannerYukle();

    }
    void bannerYukle() 
    {
    if (_banner == null) 
        {
            bannerOlustur();

            var _AdRequest= new AdRequest.Builder().Build();

            _banner.LoadAd(_AdRequest);

            //DINLEME

            ReklamOlaylariniDinle();

        }
    }

        void ReklamOlaylariniDinle() 
    {
        _banner.OnBannerAdLoaded += () =>

        {
            Debug.Log("reklam basariyla eklendi");
        };

        _banner.OnBannerAdLoadFailed += (LoadAdError error) =>

        {
            Debug.Log("reklam yüklenemedi"+"\n"+error+"hatasý");
            bannerYukle();
        };
    }


    void bannerOlustur() 
    {
         
        if (_banner != null) 
        {
            _banner.Destroy();
            _banner = null;

            }AdSize Adsize = new(320,100);//320 100 COZUNURLUKTE
            _banner = new BannerView(_reklamID,Adsize,AdPosition.Bottom);//asaðý orta posizyonda
        
    }
}
