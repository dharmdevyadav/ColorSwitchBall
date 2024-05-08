using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  [SerializeField]AudioSource audioClip;
  [SerializeField]AudioClip ErrorEffect;
  [SerializeField]AudioClip FinishEffect;
  [SerializeField]AudioClip PointCollectEffect;

  public void PlaycoinCollect()
  {
    audioClip.PlayOneShot(PointCollectEffect);
  }
  public void PlayErrorEffect()
  {
    audioClip.PlayOneShot(ErrorEffect);
  }
  public void PlayFinishEffect()
  {
    audioClip.PlayOneShot(FinishEffect);
  }
}
