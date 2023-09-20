using UnityEngine;
using UnityEngine.UI;


public class Countdown : MonoBehaviour
{
    public VehicleBehaviour.WheelVehicle vehicle;
    public Text countdownText;
    public float startingTime = 5;
    bool vehicleIsOn = false;
    float currentTime = 0;

    private void Start ()
    {
        currentTime = startingTime;
    }
    private void Update ()
    {
        currentTime -= 1 * Time.deltaTime;

        countdownText.text = currentTime.ToString ( "0" );

        if ( currentTime <= 0 )
        {
            currentTime = 0;
            
            if ( vehicleIsOn == false )
            {
                vehicleIsOn = true;
                
                vehicle.IsPlayer = true;
            }

            countdownText.enabled = false;
        }
    }
}
