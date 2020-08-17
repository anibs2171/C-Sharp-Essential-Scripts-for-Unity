using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Bomb : MonoBehaviour
{
    [Header("Unity Setup")]
    public ParticleSystem bombParticles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Instantiate(bombParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}
