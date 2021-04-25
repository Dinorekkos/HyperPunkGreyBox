using UnityEngine;

public class SongObject : MonoBehaviour 
{
    public BeatController beatControllerScript = new BeatController();
    private double dspTimeSong = AudioSettings.dspTime;
    AudioSource songGmOj;
    AudioClip mySong;
    private float pitchValue = 1;


     private void Awake() 
    {
        songGmOj = GetComponent<AudioSource>();
        songGmOj.clip = mySong;
        beatControllerScript.Bpm = 241;
        beatControllerScript.Offset = 2.9f;
        songGmOj.pitch = pitchValue;
        beatControllerScript.SongPosition = (float)(AudioSettings.dspTime - dspTimeSong) * pitchValue - beatControllerScript.Offset;
    }
     private void Update() 
    {

        if (beatControllerScript.SongPosition > 0)
        {
            CreateNote(); 
        }
    }


    private void CreateNote()
    {
        Debug.Log(beatControllerScript.SongPosition);  
    }


}