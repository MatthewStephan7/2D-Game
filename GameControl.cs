using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene("Scene01");
    }
    public void ResetSceneYEasy()
    {
        SceneManager.LoadScene("Scene_Yellow_Easy");
    }
    public void ResetSceneYMed()
    {
        SceneManager.LoadScene("Scene_Yellow_Med");
    }
    public void Blue()
    {
        SceneManager.LoadScene("Scene_Difficulty_Blue");
    }
    public void Yellow()
    {
        SceneManager.LoadScene("Scene_Difficulty_Yellow");
    }
    public void Purple()
    {
        SceneManager.LoadScene("Scene_Difficulty_Purple");
    }
    public void Yellow_Easy()
    {
        SceneManager.LoadScene("Scene_Yellow_Easy");
    }
    public void Yellow_Med()
    {
        SceneManager.LoadScene("Scene_Yellow_Med");
    }
    public void Yellow_Hard()
    {
        SceneManager.LoadScene("Scene_Yellow_Hard");
    }
    public void Blue_Easy()
    {
        SceneManager.LoadScene("Scene_Blue_Easy");
    }
    public void Blue_Med()
    {
        SceneManager.LoadScene("Scene01");
    }
    public void Blue_Hard()
    {
        SceneManager.LoadScene("Scene_Blue_Hard");
    }
    public void Purple_Easy()
    {
        SceneManager.LoadScene("Scene_Purple_Easy");
    }
    public void Purple_Med()
    {
        SceneManager.LoadScene("Scene_Purple_Med");
    }
    public void Purple_Hard()
    {
        SceneManager.LoadScene("Scene_Purple_Hard");
    }
    public void Scene_Play()
    {
        SceneManager.LoadScene("Scene_Player_Color");
    }
    public void Scene_Name()
    {
        SceneManager.LoadScene("Player_Name");
    }
    public void Quit_Scene()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void Button_Back()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void About_Scene()
    {
        SceneManager.LoadScene("Scene_About");
    }
    public void Scene_Settings()
    {
        SceneManager.LoadScene("Scene_Settings");
    }
    public void Scene_Credits()
    {
        SceneManager.LoadScene("Scene_Credits");
    }
}
