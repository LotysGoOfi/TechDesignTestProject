using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   public void OpenSceneOne()
   {
      SceneManager.LoadScene("one_scene");
   }
   public void OpenSceneTwo()
   {
      SceneManager.LoadScene("two_scene");
   }
}
