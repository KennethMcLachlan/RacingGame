using UnityEngine;

public class Jump : MonoBehaviour
{
    private void OnTriggerEnter ( Collider other )
    {
        if ( other.name == "Trigger" )
        {
            VehicleBehaviour.WheelVehicle vehicle = other.GetComponentInParent<VehicleBehaviour.WheelVehicle> ();
            if ( vehicle )
            {
                vehicle.jumpEnabled = true;
            }
        }
    }
}
