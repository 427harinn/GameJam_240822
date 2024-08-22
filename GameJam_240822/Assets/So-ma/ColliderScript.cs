using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    [SerializeField] MazePlayerManager PlayerManager;
    [SerializeField] ScoreTextScript ScoreText;
    public bool isColliding = false;
    public int totalScore;
    public bool IsColliding
    {
        get { return isColliding; }
        set { 
                if (!value) 
                {
                    totalScore++;
                    PlayerManager.SlicedSpawn();
                }
                isColliding = value; 
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsColliding = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsColliding = false;
    }
}
