using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class WS : MonoBehaviour
{

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
        
    }
}
