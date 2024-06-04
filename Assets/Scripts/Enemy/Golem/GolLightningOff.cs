using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolLightningOff : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LightningAttack"))
        {
            Destroy(collision.gameObject);
        }
    }

}
