using System;
using System.Data;
using UnityEngine;

public class CheeseWin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Player")
      {
            Debug.Log("You Win!");
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      
    }
}
