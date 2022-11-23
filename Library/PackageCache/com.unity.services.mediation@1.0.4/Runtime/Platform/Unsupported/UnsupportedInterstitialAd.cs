#if !UNITY_ANDROID && !UNITY_IOS
using System;
using UnityEngine;

namespace Unity.Services.Mediation.Platform
{
    class UnsupportedInterstitialAd : IPlatformInterstitialAd
    {
        const string k_PackageTag = "Mediation";
        const string k_UnsupportedWarning = "{0}: Unity Mediation is not supported on this platform";

        public UnsupportedInterstitialAd(string adUnitId)
        {
            Debug.unityLogger.LogWarning(k_PackageTag, string.Format(k_UnsupportedWarning, System.Reflection.MethodBase.GetCurrentMethod().Name));
        }

#pragma warning disable 67
        public event EventHandler OnLoaded;

        public event EventHandler<LoadErrorEventArgs> OnFailedLoad;

        public event EventHandler OnShowed;

        public event EventHandler OnClicked;

        public event EventHandler OnClosed;

        public event EventHandler<ShowErrorEventArgs> OnFailedShow;
#pragma warning restore 67
        public AdState AdState => AdState.Unloaded;

        public string AdUnitId { get; }

        public void Load()
        {
            Debug.unityLogger.LogWarning(k_PackageTag, string.Format(k_UnsupportedWarning, System.Reflection.MethodBase.GetCurrentMethod().Name));
        }

        public void Show()
        {
            Debug.unityLogger.LogWarning(k_PackageTag, string.Format(k_UnsupportedWarning, System.Reflection.MethodBase.GetCurrentMethod().Name));
        }

        public void Dispose() {}
    }
}
#endif
