using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using TMPro;

public class reklam_odullu : MonoBehaviour
{
#if UNITY_EDITOR
    string _reklamID = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_PHONE
string _reklamID =" ";
#elif ANDROID
string _reklamID=" ";
#elif IOS
string _reklamID=" ";
#else
string _reklmaID="unused";
#endif


    public TextMeshProUGUI degerText;
    RewardedAd _odulluReklam;

    private void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {

        });
        OdulluReklamYukle();
    }

    void OdulluReklamYukle() 
    {
        if (_odulluReklam!=null)
        {
            _odulluReklam.Destroy();
            _odulluReklam = null;
        }

        var _AdRequest=new AdRequest.Builder().Build();

        RewardedAd.Load(_reklamID, _AdRequest,
            (RewardedAd Ad, LoadAdError error) =>
            {
                if (error != null || Ad == null)
                {
                    Debug.Log("Ödüllü reklam yüklenemedi " + error);
                    
                    }
                _odulluReklam=Ad;
            }

            );
        //dinleme
        ReklamOlaylariniDinle(_odulluReklam);
    }


    void ReklamOlaylariniDinle(RewardedAd Ad) 
    {
        Ad.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(string.Format("ödüllü reklamý {0},{1}.",
                adValue.Value,
                adValue.CurrencyCode
                ));
        };

        Ad.OnAdImpressionRecorded += () =>
            {
                Debug.Log("ödüllü reklam 1 gösterim kaydetti");
        };

        Ad.OnAdClicked += () => 
        {
            Debug.Log("ödüllü reklama týklandý");
        };

        Ad.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("ödüllü reklam full ekran açýldý");
        };
        Ad.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("ödüllü reklam full ekran kapatýldý");
            OdulluReklamYukle();
        };
        Ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.Log("ödüllü reklam açýlamadý. HATA:"+ error);
            OdulluReklamYukle();
        };
    }
    public void reklamGoster() 
    {
        const string odulMesajý = "Ödülü kazandýnýz : {0},{1}";
        if (_odulluReklam!=null  && _odulluReklam.CanShowAd())
        {
            _odulluReklam.Show((Reward reward) =>
            {
                Debug.Log(string.Format(odulMesajý, reward.Type, reward.Amount));
                degerText.text = reward.Amount.ToString();

            });
        }
        else
        {
            Debug.Log("ödüllü reklam henüz hazýr deðil");
        }
    
    }
    void ReklamOldur() 
    {
        _odulluReklam.Destroy();
    }

}
