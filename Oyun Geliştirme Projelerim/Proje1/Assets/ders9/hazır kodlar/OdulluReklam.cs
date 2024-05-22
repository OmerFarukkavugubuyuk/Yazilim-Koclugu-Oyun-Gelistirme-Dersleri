using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdulluReklam : MonoBehaviour
{

#if UNITY_EDITOR
    string _adUnitID = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
        string _adUnitID = "ca-app-pub-3940256099942544/1712485313";
#else
        string _adUnitID = "unused";
#endif

    RewardedAd _OdulluReklam;
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {

        });
        OdulluReklamOlustur();
    }

    void OdulluReklamOlustur()
    {
        if (_OdulluReklam != null)
        {
            _OdulluReklam.Destroy();
            _OdulluReklam = null;
        }

        var _AdRequest = new AdRequest.Builder().Build();

        RewardedAd.Load(_adUnitID, _AdRequest,
            (RewardedAd Ad, LoadAdError error) =>
            {
                if (error != null || Ad == null)
                {

                    Debug.LogError("Ödüllü reklam yüklenirken hata oluþtu HATA : " + error);
                    return;
                }

                _OdulluReklam = Ad;

            });

        ReklamOlaylariniDinle(_OdulluReklam);
    }
    void ReklamOlaylariniDinle(RewardedAd ad)
    {
        ad.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(string.Format("Ödüllü reklamý {0} {1}.",
                adValue.Value,
                adValue.CurrencyCode));
        };

        ad.OnAdImpressionRecorded += () =>
        {
            Debug.Log("Ödüllü reklam bir gösterim kaydetti..");
        };

        ad.OnAdClicked += () =>
        {
            Debug.Log("Ödüllü reklam Týklandý.");
        };

        ad.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("Ödüllü reklam tam ekran açýldý");
        };

        ad.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("Ödüllü reklam kapatýldý.");
            OdulluReklamOlustur();
        };

        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.Log("Ödüllü reklam açýlamadý. HATA : " + error);
            OdulluReklamOlustur();
        };
    }
    public void OdulluReklamGoster()
    {
        const string OdulMesaji = "Ödül Kazanýldý. Ürün : {0}, Deðer {1}";

        if (_OdulluReklam != null && _OdulluReklam.CanShowAd())
        {
            _OdulluReklam.Show((Reward reward) =>
            {
                Debug.Log(string.Format(OdulMesaji, reward.Type, reward.Amount));

            });
        }
        else
        {
            Debug.Log("Ödüllü reklam henüz hazýr deðil");
        }

    }
    void ReklamiOldur()
    {
        _OdulluReklam.Destroy();
    }
}
