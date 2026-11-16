using UnityEngine;
using FMODUnity;
using FMOD.Studio;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class WS : MonoBehaviour
{

    public float timer = 5f;
    
    public EventInstance instans;
    public EventReference referens;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instans = RuntimeManager.CreateInstance(referens);
        instans.start();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            instans.setParameterByName("Prog", 1);
        }
    }
}
