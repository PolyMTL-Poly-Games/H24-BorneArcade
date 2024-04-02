using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SFXController : MonoBehaviour
{
    public SFXChannelSO sfxChannel;

    public void OnPunchTriggered()
    {
        sfxChannel.RaisePunchSFXEvent();
    }

    public void OnPunchHitTriggered()
    {
        sfxChannel.RaisePunchHitSFXEvent();
    }

    public void OnKatanaTriggered()
    {
        StartCoroutine(PlayWithDelay(sfxChannel.RaiseKatanaSFXEvent, 0.5f));
    }
    
    private IEnumerator PlayWithDelay(Action action, float delay)
    {
        yield return new WaitForSeconds(delay);
        action();
    }
}
