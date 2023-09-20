using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveSystem : MonoBehaviour
{
    private void Awake ()
    {
        PlayerPrefs.GetInt ( "car", 0 );
        PlayerPrefs.GetInt ( "track", 1 );
    }

    public void SetCarType ( int id )
    {
        PlayerPrefs.SetInt ( "car", id );
    }
    public void SetTrackType ( int id )
    {
        PlayerPrefs.SetInt ( "track", id );
    }
        
    public void GotoLevel ()
    {
        int id = PlayerPrefs.GetInt ( "track", 0 );

        SceneManager.LoadScene ( id );
    }
}
