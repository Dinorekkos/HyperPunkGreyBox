public class BeatController
{
    private float bpm; // bpm = 241
    private float crotchet;
    private float offset;
    private float songPosition;
    
    public BeatController()
    {
        
    }
    public BeatController(float aBpm, float aCrotchet, float aOffset, float aSongPosition)
    {
        bpm = aBpm;
        crotchet = aCrotchet;
        offset = aOffset;
        songPosition = aSongPosition; 
    }
    public float Bpm
    {
        get {return bpm;}
        set {bpm = value;}        
    }
    public float Crotchet
    {
        get {return crotchet;}
        set {crotchet = value;}
    }
    public float Offset
    {
        get {return offset;}
        set {offset = value;}
    }
    public float SongPosition 
    {
        get {return songPosition;}
        set {songPosition = value;}
    }




}