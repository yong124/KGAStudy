using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class UiManager : MonoBehaviour
{
    public Image BG;
    public Image father;
    public Sprite changeImage;
    public Button PressBt;
    public int testValue = 1;
    bool isChanged;
    [SerializeField]
    Sprite defaultSprite;
    public TextMeshProUGUI deceive;
    string[] desc = new string[5];
    
    public void Start()
    {
        defaultSprite = BG.sprite;
    }
    public void ChangeColor()
    {
        
        
        if (isChanged == false)
        {

            isChanged = true;
            BG.sprite = changeImage;
            deceive.text = "JJangu you decive me?";
            BG.sprite = changeImage;
            BG.enabled = false;
            father.enabled = true;
                

        }
        else
        {
            isChanged = false;
            BG.sprite = defaultSprite;
            deceive.text = "Father   you decive me?";
            BG.enabled = true;
            father.enabled = false;
            

        }
        
    }
   
}
