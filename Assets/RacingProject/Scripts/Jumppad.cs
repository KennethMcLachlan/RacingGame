using UnityEngine;

public class Jumppad : MonoBehaviour
{
    public float jumpforce = 10;

    private void OnTriggerEnter ( Collider other )
    {
        if ( other.name == "Trigger" )
        {
            VehicleBehaviour.WheelVehicle vehicle = other.GetComponentInParent<VehicleBehaviour.WheelVehicle> ();
            if ( vehicle )
            {
                vehicle.Jumppad ( jumpforce );
            }
        }
    }
}
