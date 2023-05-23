using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class fireBulletOnActivate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(fireBullet);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void fireBullet(ActivateEventArgs args)
    {
        GameObject spawnBullet = Instantiate(bullet);
        spawnBullet.transform.position = spawnPoint.position;
        spawnBullet.GetComponent<Rigidbody>().velocity= spawnPoint.forward*speed;
        Destroy(spawnBullet, 5);
    }
}
