﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


//Essentially, we are creating a custom class called Sound and defining its attributes.

[System.Serializable] //This allows unity to recognise this script as a custom class.
public class Sound //Notice MonoBehaviour was removed.
{
    public string name;

    public AudioClip clip;

    [Range(0f,1f)] //This allows to make a range slider in Unity for the variable below.
    public float volume;
    [Range(0f,1f)] //same here. Slider for pitch.
    public float pitch;

    public bool loop;

    //This means that even though the variable is public to be accessed by other scripts, it won't show in the unity inspector.
    //We do this because this is not a variable we want to be able to tweak as it's autogenerated by the audio manager.
    [HideInInspector] 
    public AudioSource source;
}
