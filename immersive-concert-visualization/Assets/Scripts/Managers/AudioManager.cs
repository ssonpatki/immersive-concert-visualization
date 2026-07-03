// script creates global music controller that:
    // exists only once (singleton)
    // survices scene change
    // plays music through one AudioSource
    // lets other systems read timing via CurrentTime
    // provides basic playback controls

using UnityEngine;  // import unity core library

// class AudioManager inheriting from MonoBehavior (i.e., can be attached to gameobject)
public class AudioManager : MonoBehavior
{
    // w/ singleton references: 
        // static == only one shared cpy across whole game
        // public get == let other scripts access it
        // private set == only this class can assign it
    public static AudioManager Instance { get; private set; }    // singleton
    
    private AudioSource audioSource;    // store audio component that plays music
    private AudioClip currentSong;  // currently selected song
    
    // if audioSource != null then return audioSource.time, else return 0f instead of crashing
    public float CurrentTime => audioSource != null ? audioSource.time : 0f;    // let other scripts read curr playback time (sec)
    public bool IsPlaying => audioSource != null && audioSource.isPlaying;  // if music currently playing
    private void Awake()    // initialization
    {
        if (Instance != null && Instance != this)   // check if another AudioManager exists (prevent duplicates)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;    // set singleton ref to this instance
        DontDestroyOnLoad(gameObject);  // keep gameobject alive when switching scenes
        audioSource = GetComponent<AudioSource>();  // find audiosource attached to gameobject
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();   // if audiosource doesn't already exist, create one at runtime
        }
        audioSource.playOnAwake = false;
    }

    private void PlaySong(AudioClip song)   // playback control
    {
        if (song == null)
        {
            Debug.LogWarning("AudioManager: Tried to play null song.");
            return;
        }
        currentSong = song;
        audioSource.clip = currentSong;
        audioSource.Play();
    }

    public void StopSong()
    {
        audioSource.Stop();
    }

    public void PauseSong()
    {
        audioSource.Pause();
    }

     public void ResumeSong()
    {
        audioSource.UnPause()
    }
}