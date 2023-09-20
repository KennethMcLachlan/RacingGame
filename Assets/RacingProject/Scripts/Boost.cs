using UnityEngine;

public class Boost : MonoBehaviour
{
    private void OnTriggerEnter ( Collider other )
    {
        if ( other.name == "Trigger" )
        {
            VehicleBehaviour.WheelVehicle vehicle = other.GetComponentInParent<VehicleBehaviour.WheelVehicle> ();
            if ( vehicle )
            {
                vehicle.allowBoost = true;
            }
        }
    }
}
