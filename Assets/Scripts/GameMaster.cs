using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public int boxNum;
    public float nowTime;
    // Start is called before the first frame update
    void Start()
    {
        nowTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        nowTime += Time.deltaTime;
        if (boxNum <= 0) {
            GameOver(nowTime.ToString("F0") + "s Clear");
        }
    }

    public void GameOver(string resultMessage) 
    {
        DataSender.reultMessage = resultMessage;
        SceneManager.LoadScene("Result");
    }
}
