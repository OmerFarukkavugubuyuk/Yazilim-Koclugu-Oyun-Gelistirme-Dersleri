using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OdulluGecisReklam : MonoBehaviour
{

#if UNITY_EDITOR
    string _adUnitID = "ca-app-pub-3940256099942544/5354046379";
#elif UNITY_IPHONE
        string _adUnitID = "ca-app-pub-3940256099942544/6978759866";
#else
        string _adUnitID = "unused";
#endif

    RewardedInterstitialAd _OdulluGecisReklam;
    void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {

        });
        OdulluGecisReklamOlustur();
    }

    void OdulluGecisReklamOlustur()
    {
        if (_OdulluGecisReklam != null)
        {
            _OdulluGecisReklam.Destroy();
            _OdulluGecisReklam = null;
        }

        var _AdRequest = new AdRequest.Builder().Build();

        RewardedInterstitialAd.Load(_adUnitID, _AdRequest,
            (RewardedInterstitialAd Ad, LoadAdError error) =>
            {
                if (error != null || Ad == null)
                {

                    Debug.LogError("Ödüllü Geciþ reklam yüklenirken hata oluþtu HATA : " + error);
                    return;
                }

                _OdulluGecisReklam = Ad;

            });

        ReklamOlaylariniDinle(_OdulluGecisReklam);
    }
    void ReklamOlaylariniDinle(RewardedInterstitialAd ad)
    {
        ad.OnAdPaid += (AdValue adValue) =>
        {
            Debug.Log(string.Format("Ücretli geçiþ reklamý {0} {1}.",
              adValue.Value,
                adValue.CurrencyCode));
        };

        ad.OnAdImpressionRecorded += () =>
        {
            Debug.Log("Ödüllü Geçiþ reklamý bir gösterim kaydetti.");
        };

        ad.OnAdClicked += () =>
        {
            Debug.Log("Ödüllü Geçiþ reklamý týklandý.");
        };

        ad.OnAdFullScreenContentOpened += () =>
        {
            Debug.Log("Ödüllü Geçiþ reklamý açýldý.");
        };

        ad.OnAdFullScreenContentClosed += () =>
        {
            Debug.Log("Ödüllü Geçiþ reklamý kapatýldý.");
            OdulluGecisReklamOlustur();
        };

        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.Log("Geçiþ reklamý tam ekran açýlamadý. HATA : " + error);
            OdulluGecisReklamOlustur();
        };
    }
    public void OdulluGecisReklamGoster()
    {
        const string OdulMesaji = "Ödüllü Geçiþ Kazanýldý. Ürün : {0}, Deðer {1}";

        if (_OdulluGecisReklam != null && _OdulluGecisReklam.CanShowAd())
        {
            _OdulluGecisReklam.Show((Reward reward) =>
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
        _OdulluGecisReklam.Destroy();
    }
}
