using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Cherries = 0;
    [SerializeField] private Text CherriesText;
    [SerializeField] private AudioSource CollectSoundEffect;

   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.CompareTag("Cherry"))
    {
        CollectSoundEffect.Play();
        Destroy(collision.gameObject);
        Cherries++;
        CherriesText.text = "Cherries: " + Cherries;
    }

   }
}
