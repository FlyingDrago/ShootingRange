using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
    private const int leftMouseButton = 0;



    public GameObject grenadePrefab;
    public Transform firingPos;
    public float bulletSpeed;
    public AudioSource shottingSound;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(leftMouseButton))
        {
            ShootBullet();
        }
    }
    private void ShootBullet()
    {
        GameObject bullet = Instantiate(grenadePrefab, firingPos.position, firingPos.rotation);
        bullet.GetComponent<Rigidbody>().velocity = firingPos.forward * bulletSpeed;
        if (shottingSound != null)
        {
            shottingSound.Play();
        }
    }
}
