using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireworks : MonoBehaviour
{
    [SerializeField] ParticleSystem[] m_particles;

    private void Start()
    {
        StartCoroutine(StartFireWorks());
    }

    IEnumerator StartFireWorks()
    {
        while(true)
        {
            int index = (int)Mathf.Floor(Random.Range(0.0f, m_particles.Length));
            m_particles[index].Emit(60);
            Debug.Log("Boom!");
            yield return new WaitForSeconds(Random.Range(0.0f, 1.0f) + 1.0f);
        }
    }
}
