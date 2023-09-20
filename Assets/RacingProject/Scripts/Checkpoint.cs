using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Timer timer;

    private void OnTriggerEnter ( Collider other )
    {
        if ( other.name == "Trigger")
        {
            timer.checkPointReached = true;
        }
    }
}
