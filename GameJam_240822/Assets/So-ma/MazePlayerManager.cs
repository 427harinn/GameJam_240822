using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MazePlayerManager : MonoBehaviour
{
    [SerializeField] private Sprite[] playerSprits;
    [SerializeField] private GameObject[] slicedObjects;
    [SerializeField] private GManager gManager;
    [SerializeField] private int nextStageIndex = 2;
    public int dragGameScore = 0;
    public int nowVegetableNum = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            this.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 8));
        }
    }
    void Start()
    {
        SpriteRenderer imageComponent = this.GetComponent<SpriteRenderer>();
        imageComponent.sprite= playerSprits[nowVegetableNum];
    }

    public void SlicedSpawn()
    {
        Instantiate(slicedObjects[nowVegetableNum], new Vector2(this.transform.position.x,0), Quaternion.identity);
    }

    public void GameFinish()
    {
        gManager.SetDragGameScore(dragGameScore);
        gManager.stageIndex = nextStageIndex;
        UnityEngine.SceneManagement.SceneManager.LoadScene("StageRandomSelect");
    }
}
