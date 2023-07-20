using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private const float PIPE_WIDTH = 7.8f;
    private const float PIPE_HEAD_HEIGHT = 3.75f;
    private const float CAMERA_SIZE = 50f;

    public Transform pipeBody;
    public Transform pipeHead;

    private void Start()
    {
        CreatePipe(40f, 20f, true);
        CreatePipe(40f, 20f, false);

    }
    private void Update()
    {
        kskje();

    }
    private Transform CreatePipe(float height , float xPositon, bool createButton)
    {
        //SET HEAD
        Transform PipeHead = Instantiate(pipeHead);
        float pipeHeadYposition;
        if (createButton) 
        {
            pipeHeadYposition = -CAMERA_SIZE + height - PIPE_HEAD_HEIGHT * 0.5f;
        }
        else
        {
            pipeHeadYposition = +CAMERA_SIZE - height + PIPE_HEAD_HEIGHT * 0.5f;
        }
        PipeHead.position = new Vector3(xPositon, pipeHeadYposition);

        return PipeHead;

        //SET BODY
        Transform PipeBody = Instantiate(pipeBody);
        float pipeBodyYposition;
        if (createButton)
        {
            pipeBodyYposition = -CAMERA_SIZE;
        }
        else
        {
            pipeBodyYposition = +CAMERA_SIZE;
            PipeBody.localScale = new Vector3(1, -1, 1);
        }
        PipeBody.position = new Vector3(xPositon, pipeBodyYposition);

        SpriteRenderer pipeBodySpriteRenderer = PipeBody.GetComponent<SpriteRenderer>();
        pipeBodySpriteRenderer.size = new Vector2(PIPE_WIDTH, height);

        BoxCollider2D pipeBodyBoxCollider = PipeBody.GetComponent<BoxCollider2D>();
        pipeBodyBoxCollider.size = new Vector2(PIPE_WIDTH, height);
        pipeBodyBoxCollider.offset = new Vector2(0f, height * 0.5f);
 
    }
    public void kskje()
    {
        Transform PipeHead = CreatePipe(40f, 20f, true);
        PipeHead.position += new Vector3(PipeHead.position.x + 1f, PipeHead.position.y, PipeHead.position.z);
    }
}
