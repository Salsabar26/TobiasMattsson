using UnityEngine;
using Gamekit3D;

public class HealthPickup : MonoBehaviour
{
    [SerializeField] private string requiredTag = "Player";
    [SerializeField] private bool destroyOnTrigger = true;
    private HungerManager hM;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hM = GameObject.Find("HungerManager").GetComponent<HungerManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == requiredTag)
        {
            other.GetComponent<Damageable>().ResetDamage();
            hM.ResetTimer();
            if (destroyOnTrigger == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
