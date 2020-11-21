using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongPause : SongInteract
{

    public override void intaractVR()
    {
        song.Pause();
    }
}
