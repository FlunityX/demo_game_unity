using UnityEngine.SceneManagement;
using UnityEngine;

public class chungnang : MonoBehaviour
{
    public void start()
    {
SceneManager.LoadScene(0);
    }
    public void choimoi()
    {
        // Viết code xử lý cho phương thức choimoi ở đây
        SceneManager.LoadScene(1);
    }

    public void thoatramenu()
    {
        // Viết code xử lý cho phương thức thoat ở đây
        SceneManager.LoadScene(0);
        

    }
    public void thoat()
    {
        Application.Quit();
    }
    public void huongdan()
{
    SceneManager.LoadScene(2);

}
public void thoathuongdan()
{
    SceneManager.LoadScene(0);
}

}
