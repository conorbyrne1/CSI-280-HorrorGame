using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voiceline : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayRandomAudio());
    }

    // Update is called once per frame
    IEnumerator PlayRandomAudio()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);

            // Check if there are audio clips in the array
            if (clips.Length > 0)
            {
                int randomIndex = Random.Range(0, clips.Length);
                AudioClip randomClip = clips[randomIndex];
                source.PlayOneShot(randomClip);
            }
            else
            {
                Debug.LogWarning("No audio clips assigned to the array.");
            }

        }
    }

}

