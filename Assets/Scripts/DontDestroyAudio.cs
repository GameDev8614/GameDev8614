using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    private static DontDestroyAudio _instance;
    
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
}
