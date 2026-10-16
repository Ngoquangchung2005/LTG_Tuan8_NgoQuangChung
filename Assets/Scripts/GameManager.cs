
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Popup UI")]
    public Canvas GameMenu;
    public TMP_Text Title;
    public TMP_Text Message;
    public Button EnterButton;
    public Button RestartButton;

    [Header("Scene")]
    public string nextSceneName = "";

    private void Start()
    {
        // Ẩn popup khi bắt đầu game
        GameMenu.enabled = false;

        // Thiết lập nội dung bằng code
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";

        EnterButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    // Chuyển sang scene tiếp theo
    public void NextScene()
    {
        if (string.IsNullOrWhiteSpace(nextSceneName))
        {
            Debug.LogWarning("Bạn chưa nhập tên scene tiếp theo!");
            return;
        }

        SceneManager.LoadScene(nextSceneName);
    }

    // Chơi lại scene hiện tại
    public void RestartScene()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().buildIndex
        );
    }
}
