using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToggleObject : MonoBehaviour
{
    public GameObject[] objectsInScene;
    public Material mat1, mat2;//mat 1 is inactive state and mat2 is active state;
    public void Toggle() {
        int length = objectsInScene.Length;
        for (int i=0;i<length;i++) {
            if (objectsInScene[i].name == SpawnObjects.nameOfObject)
            {
                objectsInScene[i].GetComponent<MeshRenderer>().material = mat2;
                objectsInScene[i].GetComponentInChildren<ParticleSystem>().Play();
                objectsInScene[i].GetComponentInChildren<TextMeshPro>().GetComponent<TextMeshPro>().enabled = true;
            }
            else
            {
                objectsInScene[i].GetComponent<MeshRenderer>().material = mat1;
                objectsInScene[i].GetComponentInChildren<TextMeshPro>().GetComponent<TextMeshPro>().enabled = false;
            }
        }
    }
    public void resetMat()
    {
        for (int i=0;i<objectsInScene.Length;i++) 
        {
            objectsInScene[i].GetComponent<MeshRenderer>().material = mat1;
        }
        SceneManager.LoadScene("MenuScene");
    }
}
