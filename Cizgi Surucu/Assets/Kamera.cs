using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject CmVcam;

    public GameObject Player;
    int yeni = 14;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Player.transform.position.x > yeni) || (Player.transform.position.y > 8))

        {
            CmVcam.SetActive(true);

        }

    }
}
