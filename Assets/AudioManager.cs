using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    //THIS CODE IS IF YOU WANT A PERSISTENT AUDIO MANAGER ACROSS SCENES.
    //public static AudioManager instance;

    // Awake is pretty much like start but it's called right before it. (Start is called before the first frame update).
    void Awake()
    {
        //THIS CODE IS IF YOU WANT A PERSISTENT AUDIO MANAGER ACROSS SCENES.
        //if (instance == null)
        //{
        //    instance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}
        //DontDestroyOnLoad(gameObject); //This means the AudioManager will be persistent across scenes.

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    //Sounds in here will play as soon as the AudioManager is loaded into a scene.
    private void Start()
    {
        //This will play the Music attributed to each level provided the level song shares the same name as the scene.
        string activeScene = SceneManager.GetActiveScene().name;
        Play(activeScene);
    }

    public void Play (string name)
    {
        Sound s = System.Array.Find(sounds, sound => sound.name == name); //this is a handy function that look for things in arrays. param1 is the array name then so on.
        
        //This means if the referenced sound has a typo or can't be found or something, this will prevent an error by just not playing it.
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        
        s.source.Play();
    }


    /*   FROM A YOUTUBE COMMENT ON HOW TO STOP SOUNDS. MAYBE ADD LATER.
     *   If anyone is curious on how to stop playing a looping sound (maybe you want to switch bg music when you enter a new area) just use s.source.Stop (); You can just add a method to the Audio Manager like this
     *
     *   public void StopPlaying (string sound)
     *   {
     *   Sound s = Array.Find(sounds, item => item.name == sound);
     *   if (s == null)
     *   {
     *     Debug.LogWarning("Sound: " + name + " not found!");
     *     return;
     *   }
     *
     *   s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
     *   s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));
     *
     *   s.source.Stop ();
     *   }
     *
     *  just call it like this (AudioManagerReferenceGoeshere).StopPlaying("sound string name");
     */
}
