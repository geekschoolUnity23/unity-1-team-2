using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    private Transform _shootPoint;

    [SerializeField]
    private GameObject _bullet;

    [SerializeField]
    private float _force;

    [SerializeField]
    private AudioSource sound;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sound.PlayOneShot(sound.clip);
            GameObject instantiateBullet = Instantiate(_bullet, _shootPoint.position, Quaternion.identity);
            instantiateBullet.GetComponent<Rigidbody>().AddForce(transform.forward * _force * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
