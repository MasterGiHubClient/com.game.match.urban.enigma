using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CellGame_UrbanEnigma : MonoBehaviour
{
    [SerializeField] private GameObject icon_p_UrbanEnigma;
    [SerializeField] private Image image_of_cell_UrbanEnigma;
    [HideInInspector] public Sprite icon_for_cell_UrbanEnigma;






    public static Action<LevelData_UrbanEnigma> set_level_UrbanEnigma = delegate { };
    public static Action<Sprite, int> on_set_icon_UrbanEnigma = delegate { };
    public static Action<bool> show_icon_UrbanEnigma = delegate { };
    private static CellGame_UrbanEnigma currentCell_UrbanEnigma = null;
    public static Action<Action> isNotFound = delegate { };



    [HideInInspector] public bool is_showing_icon_UrbanEnigma = false;
    private LevelData_UrbanEnigma levelData_UrbanEnigma = new LevelData_UrbanEnigma();



    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    // Unused integer variables
    int unusedInt1 = 42;
    int unusedInt2 = -10;
    int unusedInt3 = 987;

    // Unused float variables
    float unusedFloat1 = 3.14f;
    float unusedFloat2 = -2.5f;
    float unusedFloat3 = 1.618f;

    // Unused boolean variables
    bool unusedBool1 = true;
    bool unusedBool2 = false;
    bool unusedBool3 = true;

    // Unused string variables
    string unusedString1 = "Hello, world!";
    string unusedString2 = "Unity is awesome";
    string unusedString3 = "Garbage variables";

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<





    private void OnEnable()
    {
        on_set_icon_UrbanEnigma += SetUpIconForGame_UrbanEnigma;
        show_icon_UrbanEnigma += Show_Icon_UrbanEnigma;
        isNotFound += IsNotFound;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_Random_Logic = false;
        if (run_Random_Logic)
        {
            // Generate some random integers and floats
            int randomInt1 = UnityEngine.Random.Range(0, 100);
            int randomInt2 = UnityEngine.Random.Range(-50, 50);
            float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
            float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

            // Perform some random calculations
            int result1 = randomInt1 + randomInt2;
            float result2 = randomFloat1 * randomFloat2;

            // Create a random bool
            bool randomBool = UnityEngine.Random.value > 0.5f;

            // Concatenate some random strings
            string randomString1 = "Random String " + randomInt1;
            string randomString2 = "Another Random String " + randomFloat1;

            // Create a random GameObject
            GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

            // Add the random GameObject as a child of the current GameObject
            randomGameObject.transform.SetParent(transform);

            // Log the results
            Debug.Log($"UnusedMethodWithRandomLogic:");
            Debug.Log($"  randomInt1: {randomInt1}");
            Debug.Log($"  randomInt2: {randomInt2}");
            Debug.Log($"  randomFloat1: {randomFloat1}");
            Debug.Log($"  randomFloat2: {randomFloat2}");
            Debug.Log($"  result1: {result1}");
            Debug.Log($"  result2: {result2}");
            Debug.Log($"  randomBool: {randomBool}");
            Debug.Log($"  randomString1: {randomString1}");
            Debug.Log($"  randomString2: {randomString2}");
            Debug.Log($"  randomGameObject: {randomGameObject.name}");
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }
    private void OnDisable()
    {
        on_set_icon_UrbanEnigma -= SetUpIconForGame_UrbanEnigma;
        show_icon_UrbanEnigma -= Show_Icon_UrbanEnigma;
        isNotFound -= IsNotFound;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_Random_Logic = false;
        if (run_Random_Logic)
        {
            // Generate some random integers and floats
            int randomInt1 = UnityEngine.Random.Range(0, 100);
            int randomInt2 = UnityEngine.Random.Range(-50, 50);
            float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
            float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

            // Perform some random calculations
            int result1 = randomInt1 + randomInt2;
            float result2 = randomFloat1 * randomFloat2;

            // Create a random bool
            bool randomBool = UnityEngine.Random.value > 0.5f;

            // Concatenate some random strings
            string randomString1 = "Random String " + randomInt1;
            string randomString2 = "Another Random String " + randomFloat1;

            // Create a random GameObject
            GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

            // Add the random GameObject as a child of the current GameObject
            randomGameObject.transform.SetParent(transform);

            // Log the results
            Debug.Log($"UnusedMethodWithRandomLogic:");
            Debug.Log($"  randomInt1: {randomInt1}");
            Debug.Log($"  randomInt2: {randomInt2}");
            Debug.Log($"  randomFloat1: {randomFloat1}");
            Debug.Log($"  randomFloat2: {randomFloat2}");
            Debug.Log($"  result1: {result1}");
            Debug.Log($"  result2: {result2}");
            Debug.Log($"  randomBool: {randomBool}");
            Debug.Log($"  randomString1: {randomString1}");
            Debug.Log($"  randomString2: {randomString2}");
            Debug.Log($"  randomGameObject: {randomGameObject.name}");
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    private void SetUpIconForGame_UrbanEnigma(Sprite icon, int index)
    {
        if ((this.gameObject.transform.GetSiblingIndex() + 1) == index)
        {
            icon_for_cell_UrbanEnigma = icon;
            image_of_cell_UrbanEnigma.sprite = icon_for_cell_UrbanEnigma;
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_Random_Logic = false;
        if (run_Random_Logic)
        {
            // Generate some random integers and floats
            int randomInt1 = UnityEngine.Random.Range(0, 100);
            int randomInt2 = UnityEngine.Random.Range(-50, 50);
            float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
            float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

            // Perform some random calculations
            int result1 = randomInt1 + randomInt2;
            float result2 = randomFloat1 * randomFloat2;

            // Create a random bool
            bool randomBool = UnityEngine.Random.value > 0.5f;

            // Concatenate some random strings
            string randomString1 = "Random String " + randomInt1;
            string randomString2 = "Another Random String " + randomFloat1;

            // Create a random GameObject
            GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

            // Add the random GameObject as a child of the current GameObject
            randomGameObject.transform.SetParent(transform);

            // Log the results
            Debug.Log($"UnusedMethodWithRandomLogic:");
            Debug.Log($"  randomInt1: {randomInt1}");
            Debug.Log($"  randomInt2: {randomInt2}");
            Debug.Log($"  randomFloat1: {randomFloat1}");
            Debug.Log($"  randomFloat2: {randomFloat2}");
            Debug.Log($"  result1: {result1}");
            Debug.Log($"  result2: {result2}");
            Debug.Log($"  randomBool: {randomBool}");
            Debug.Log($"  randomString1: {randomString1}");
            Debug.Log($"  randomString2: {randomString2}");
            Debug.Log($"  randomGameObject: {randomGameObject.name}");
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }
    private void IsNotFound(Action callback)
    {
        if (!is_showing_icon_UrbanEnigma)
        {
            callback?.Invoke();
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_Random_Logic = false;
        if (run_Random_Logic)
        {
            // Generate some random integers and floats
            int randomInt1 = UnityEngine.Random.Range(0, 100);
            int randomInt2 = UnityEngine.Random.Range(-50, 50);
            float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
            float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

            // Perform some random calculations
            int result1 = randomInt1 + randomInt2;
            float result2 = randomFloat1 * randomFloat2;

            // Create a random bool
            bool randomBool = UnityEngine.Random.value > 0.5f;

            // Concatenate some random strings
            string randomString1 = "Random String " + randomInt1;
            string randomString2 = "Another Random String " + randomFloat1;

            // Create a random GameObject
            GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

            // Add the random GameObject as a child of the current GameObject
            randomGameObject.transform.SetParent(transform);

            // Log the results
            Debug.Log($"UnusedMethodWithRandomLogic:");
            Debug.Log($"  randomInt1: {randomInt1}");
            Debug.Log($"  randomInt2: {randomInt2}");
            Debug.Log($"  randomFloat1: {randomFloat1}");
            Debug.Log($"  randomFloat2: {randomFloat2}");
            Debug.Log($"  result1: {result1}");
            Debug.Log($"  result2: {result2}");
            Debug.Log($"  randomBool: {randomBool}");
            Debug.Log($"  randomString1: {randomString1}");
            Debug.Log($"  randomString2: {randomString2}");
            Debug.Log($"  randomGameObject: {randomGameObject.name}");
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    }

    public void Show_Icon_UrbanEnigma(bool state)
    {
        icon_p_UrbanEnigma.SetActive(state);
        is_showing_icon_UrbanEnigma = state;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_Random_Logic = false;
        if (run_Random_Logic)
        {
            // Generate some random integers and floats
            int randomInt1 = UnityEngine.Random.Range(0, 100);
            int randomInt2 = UnityEngine.Random.Range(-50, 50);
            float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
            float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

            // Perform some random calculations
            int result1 = randomInt1 + randomInt2;
            float result2 = randomFloat1 * randomFloat2;

            // Create a random bool
            bool randomBool = UnityEngine.Random.value > 0.5f;

            // Concatenate some random strings
            string randomString1 = "Random String " + randomInt1;
            string randomString2 = "Another Random String " + randomFloat1;

            // Create a random GameObject
            GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

            // Add the random GameObject as a child of the current GameObject
            randomGameObject.transform.SetParent(transform);

            // Log the results
            Debug.Log($"UnusedMethodWithRandomLogic:");
            Debug.Log($"  randomInt1: {randomInt1}");
            Debug.Log($"  randomInt2: {randomInt2}");
            Debug.Log($"  randomFloat1: {randomFloat1}");
            Debug.Log($"  randomFloat2: {randomFloat2}");
            Debug.Log($"  result1: {result1}");
            Debug.Log($"  result2: {result2}");
            Debug.Log($"  randomBool: {randomBool}");
            Debug.Log($"  randomString1: {randomString1}");
            Debug.Log($"  randomString2: {randomString2}");
            Debug.Log($"  randomGameObject: {randomGameObject.name}");
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }
    public void onClick_UrbanEnigma()
    {
        Manager_Game_UrbanEnigma.instance?.CardClicked_UrbanEnigma(this);

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        bool run_Random_Logic = false;
        if (run_Random_Logic)
        {
            // Generate some random integers and floats
            int randomInt1 = UnityEngine.Random.Range(0, 100);
            int randomInt2 = UnityEngine.Random.Range(-50, 50);
            float randomFloat1 = UnityEngine.Random.Range(0f, 10f);
            float randomFloat2 = UnityEngine.Random.Range(-5f, 5f);

            // Perform some random calculations
            int result1 = randomInt1 + randomInt2;
            float result2 = randomFloat1 * randomFloat2;

            // Create a random bool
            bool randomBool = UnityEngine.Random.value > 0.5f;

            // Concatenate some random strings
            string randomString1 = "Random String " + randomInt1;
            string randomString2 = "Another Random String " + randomFloat1;

            // Create a random GameObject
            GameObject randomGameObject = new GameObject($"Random GameObject {randomInt1}");

            // Add the random GameObject as a child of the current GameObject
            randomGameObject.transform.SetParent(transform);

            // Log the results
            Debug.Log($"UnusedMethodWithRandomLogic:");
            Debug.Log($"  randomInt1: {randomInt1}");
            Debug.Log($"  randomInt2: {randomInt2}");
            Debug.Log($"  randomFloat1: {randomFloat1}");
            Debug.Log($"  randomFloat2: {randomFloat2}");
            Debug.Log($"  result1: {result1}");
            Debug.Log($"  result2: {result2}");
            Debug.Log($"  randomBool: {randomBool}");
            Debug.Log($"  randomString1: {randomString1}");
            Debug.Log($"  randomString2: {randomString2}");
            Debug.Log($"  randomGameObject: {randomGameObject.name}");
        }
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    }


    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


    void UnusedMethod1()
    {
        int randomInt = UnityEngine.Random.Range(0, 100);
        float randomFloat = UnityEngine.Random.Range(-10f, 10f);
        bool randomBool = UnityEngine.Random.value > 0.5f;

        Debug.Log($"UnusedMethod1: randomInt={randomInt}, randomFloat={randomFloat}, randomBool={randomBool}");
    }

    int UnusedMethod2(int param1, float param2)
    {
        int result = param1 * Mathf.FloorToInt(param2);
        Debug.Log($"UnusedMethod2: param1={param1}, param2={param2}, result={result}");
        return result;
    }

    bool UnusedMethod3(string param1)
    {
        bool result = param1.Length > 5;
        Debug.Log($"UnusedMethod3: param1='{param1}', result={result}");
        return result;
    }

    void UnusedMethod4(GameObject param1, Transform param2)
    {
        if (param1 != null && param2 != null)
        {
            param1.transform.position = param2.position + Vector3.up * UnityEngine.Random.Range(1f, 5f);
            Debug.Log($"UnusedMethod4: param1={param1.name}, param2={param2.name}, new position={param1.transform.position}");
        }
        else
        {
            Debug.Log("UnusedMethod4: One or both parameters are null.");
        }
    }

    float UnusedMethod5(int[] param1, float[] param2)
    {
        float result = 0f;
        for (int i = 0; i < param1.Length; i++)
        {
            result += param1[i] * param2[i];
        }
        Debug.Log($"UnusedMethod5: result={result}");
        return result;


    }

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

}
