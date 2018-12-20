using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManController : MonoBehaviour
{

    public Rotate rotatescript;
    public Spawner spawnerscript;
    public SimpleMove moveandstop;
    public GameObject cylindertoinvis_obj;
    public MeshRenderer cylindertoinvis_rend;
    public AudioSource musicplay;
    public Camera camtocontrol;
    public Color backColor;
    public TextMesh textObj;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    float textTimer = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed == 0f)
        {
            rotatescript.rotateSpeed = 180f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed >= 1f)
        {
            rotatescript.rotateSpeed = 0f;
        }
        // spawn control
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnerscript.SpawnObject();
        }
        // simple move
        if (Input.GetKeyDown(KeyCode.Alpha3) && moveandstop.moveSpeed == 0f)
        {
            moveandstop.moveSpeed = 2f;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && moveandstop.moveSpeed >= 1f)
        {
            moveandstop.moveSpeed = 0f;
        }
        CylinderControl();
        CamBackgroundControl();
        MusicControl();

        textTimer += Time.deltaTime;
        if(textTimer >5)
        {
            textObj.text = "Hello world";
            textTimer = 0;
        }
    }
    void CylinderControl()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4) && cylindertoinvis_obj.activeSelf == true)
        {
            cylindertoinvis_obj.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) && cylindertoinvis_obj.activeSelf == false)
        {
            cylindertoinvis_obj.SetActive(true);
        }
    }

    void MusicControl()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5) && musicplay.isPlaying == false)
        {
            musicplay.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) && musicplay.isPlaying == true)
        {
            musicplay.Stop();
        }
    }


bool backgroundFlag = true;
void CamBackgroundControl()
{

    if (Input.GetKeyDown(KeyCode.Alpha6) && backgroundFlag == false)
    {
            camtocontrol.backgroundColor = backColor;
            backgroundFlag = true;
    }
    else if (Input.GetKeyDown(KeyCode.Alpha6) && backgroundFlag == true)
    {
            //make random color
            Color randColor = new Color();
            randColor.r = Random.Range(0, 1f);
            randColor.b = Random.Range(0, 1f);
            randColor.g = Random.Range(0, 1f);
            camtocontrol.backgroundColor = randColor;
        backgroundFlag = false;
    }
    
}
}

