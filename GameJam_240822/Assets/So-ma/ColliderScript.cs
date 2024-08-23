using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    [SerializeField] MazePlayerManager PlayerManager;
    [SerializeField] ScoreTextScript ScoreText;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(PlayerManager.upVelocity)
        {
            PlayerManager.SlicedSpawn();
            PlayerManager.dragGameScore++;
            GManager.instance.DragGameScore++;
        }
    }
}
