using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KanKikuchi.AudioManager;
using System.Runtime.CompilerServices;

public class MazePlayerManager : MonoBehaviour
{
    [SerializeField] private Sprite[] playerSprits;
    [SerializeField] private GameObject[] slicedObjects;
    [SerializeField] private Sprite[] slicerSprites;
    [SerializeField] private GameObject slicer;
    [SerializeField] private int nextStageIndex = 2;
    public bool upVelocity = false;
    public int dragGameScore = 0;
    public int nowVegetableNum = 0;
    private Rigidbody2D rb;
    private float loc;
    private float beforeLoc;
    [SerializeField] private Vector2 slicerSpawnLoc;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 8));
        }
        loc = this.transform.position.y; 
        if(beforeLoc > loc)
        {
            upVelocity = false;
        }
        if(beforeLoc < loc)
        {
            upVelocity = true;
        }
        beforeLoc = this.transform.position.y;
    }
    void Start()
    {
        SpriteRenderer imageComponent = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
        imageComponent.sprite= playerSprits[nowVegetableNum];
        slicer.SetActive(true);
        slicer.GetComponent<SpriteRenderer>().sprite = slicerSprites[nowVegetableNum];
    }

    public void SlicedSpawn()
    {
        SEManager.Instance.Play(SEPath.SLICED);
        Instantiate(slicedObjects[nowVegetableNum], new Vector2(this.transform.position.x,0), Quaternion.identity);
    }
}
