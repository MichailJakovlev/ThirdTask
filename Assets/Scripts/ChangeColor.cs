using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    private Color newColor;
    private GameObject targetObject;

    public GameObject upBlock;
    public GameObject downBlock;
    public GameObject leftBlock;
    public GameObject cube;
    public Slider greenSlider;
    public TMP_Text redText;
    public TMP_Text greenText;
    public TMP_Text blueText;

    private float redColorValue, greenColorValue, blueColorValue;
    private float redCube = 255, greenCube = 255, blueCube = 255;
    private float redLeftBlock = 255, greenLeftBlock = 255, blueLeftBlock = 255;
    private float redUpBlock = 255, greenUpBlock = 255, blueUpBlock = 255;
    private float redDownBlock = 255, greenDownBlock = 255, blueDownBlock = 255;

    bool redPlusPressed = false;
    bool redMinusPressed = false;

    private void Start()
    {
        targetObject = cube;
        greenSlider.value = 255;
    }

    private void OnEnable()
    {
        Cube.cubeChange += ChangeCube;
        LeftBlock.leftBlockChange += ChangeLeftBolck;
        UpBlock.upBlockChange += ChangeUpBlock;
        DownBlock.downBlockChange += ChangeDownBlock;
    }

    private void OnDisable()
    {
        Cube.cubeChange -= ChangeCube;
        LeftBlock.leftBlockChange -= ChangeLeftBolck;
        UpBlock.upBlockChange -= ChangeUpBlock;
        DownBlock.downBlockChange -= ChangeDownBlock;
    }

    void ChangeCube()
    {
        targetObject = cube;
    }

    void ChangeUpBlock()
    {
        targetObject = upBlock;
    }

    void ChangeDownBlock()
    {
        targetObject = downBlock;
    }

    void ChangeLeftBolck()
    {
        targetObject = leftBlock;
    }

    public void OnPlusDown()
    {
        redPlusPressed = true;
    }

    public void OnPlusUp()
    {
        redPlusPressed = false;
    }

    public void OnMinusDown()
    {
        redMinusPressed = true;
    }

    public void OnMinusUp()
    {
        redMinusPressed = false;
    }

    public void RandomBlue()
    {
        if(targetObject == cube)
        {
            blueCube = Random.Range(0, 255);
        }

        if (targetObject == leftBlock)
        {
            blueLeftBlock = Random.Range(0, 255);
        }

        if (targetObject == upBlock)
        {
            blueUpBlock = Random.Range(0, 255);
        }

        if (targetObject == downBlock)
        {
            blueDownBlock = Random.Range(0, 255);
        }
    }

    public void ChangeGreen()
    {
        if (targetObject == cube)
        {
            greenCube = greenSlider.value;
        }

        if (targetObject == leftBlock)
        {
            greenLeftBlock = greenSlider.value;
        }

        if (targetObject == upBlock)
        {
            greenUpBlock = greenSlider.value;
        }

        if (targetObject == downBlock)
        {
            greenDownBlock = greenSlider.value;
        }
    }

    public void Update()
    {
        if (redPlusPressed)
        {
            if(targetObject == cube)
            {
                redCube++;
                if (redCube > 255)
                {
                    redCube--;
                }
            }
            if (targetObject == leftBlock)
            {
                redLeftBlock++;
                if (redLeftBlock > 255)
                {
                    redLeftBlock--;
                }
            }
            if (targetObject == upBlock)
            {
                redUpBlock++;
                if (redUpBlock > 255)
                {
                    redUpBlock--;
                }
            }
            if (targetObject == downBlock)
            {
                redDownBlock++;
                if (redDownBlock > 255)
                {
                    redDownBlock--;
                }
            }
        }

        if (redMinusPressed)
        {
            if (targetObject == cube)
            {
                redCube--;
                if (redCube < 0)
                {
                    redCube++;
                }
            }

            if (targetObject == upBlock)
            {
                redUpBlock--;
                if (redUpBlock < 0)
                {
                    redUpBlock++;
                }
            }

            if (targetObject == leftBlock)
            {
                redLeftBlock--;
                if (redLeftBlock < 0)
                {
                    redLeftBlock++;
                }
            }

            if (targetObject == downBlock)
            {
                redDownBlock--;
                if (redDownBlock < 0)
                {
                    redDownBlock++;
                }
            }
        }
        
        if (targetObject == cube)
        {
            redColorValue = redCube;
            greenColorValue = greenCube;
            blueColorValue = blueCube;
        }

        if (targetObject == leftBlock)
        {
            redColorValue = redLeftBlock;
            greenColorValue = greenLeftBlock;
            blueColorValue = blueLeftBlock;
        }

        if (targetObject == upBlock)
        {
            redColorValue = redUpBlock;
            greenColorValue = greenUpBlock;
            blueColorValue = blueUpBlock;
        }

        if (targetObject == downBlock)
        {
            redColorValue = redDownBlock;
            greenColorValue = greenDownBlock;
            blueColorValue = blueDownBlock;
        }

        redText.text = "" + redColorValue;
        greenText.text = "" + System.Convert.ToInt32(greenColorValue);
        blueText.text = "" + blueColorValue;
        greenSlider.value = greenColorValue;

        newColor = new Color(redColorValue / 255, greenColorValue / 255, blueColorValue / 255, 1);

        if (targetObject == cube)
        {
            targetObject.GetComponent<Renderer>().material.color = newColor;
        }
        else
        {
            targetObject.GetComponent<Image>().color = newColor;
        }
    }
}

    

