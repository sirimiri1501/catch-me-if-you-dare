using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hihi
{
    public class NewMonoBehaviorForGhost : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSource;

        [ContextMenu("Play Audio (with clip)")]
        public void PlayAudio(AudioClip clip)
        {
            if (audioSource == null || clip == null) return;
            audioSource.clip = clip;
            audioSource.Play();
        }

        [ContextMenu("Play Audio")]
        public void PlayAudio()
        {
            if (audioSource == null) return;
            audioSource.Play();
        }
    }
}
